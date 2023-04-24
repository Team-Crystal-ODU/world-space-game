using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravSource : MonoBehaviour
{
    public float gravStrength = 10f;
    List<Rigidbody> rigidbodys = new List<Rigidbody>();

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if(rb != null)
        {
            rigidbodys.Add(rb);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rigidbodys.Remove(rb);
        }
    }

    private void FixedUpdate()
    {
        foreach(Rigidbody rb in rigidbodys)
        {
            Vector3 direction = transform.position - rb.position;
            direction = direction.normalized;
            rb.velocity += direction * Time.deltaTime * gravStrength;

            AlignGrav aligngrav = rb.GetComponent<AlignGrav>();
            if (aligngrav != null)
            {
                aligngrav.aligndirection = -direction;
            }
        }
    }
}
