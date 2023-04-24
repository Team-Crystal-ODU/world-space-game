using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignGrav : MonoBehaviour
{
    public Vector3 aligndirection;
    

    private void FixedUpdate()
    {
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, aligndirection);
        transform.rotation = rotation;
    }

}
