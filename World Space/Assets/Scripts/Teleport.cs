using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        var direction = target.position - transform.position;
        var hit = Physics.Raycast(transform.position, direction, out RaycastHit hitinfo, 100);
        if (hit)
        {
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, -direction);
            transform.rotation = rotation;
            transform.position = hitinfo.point;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
