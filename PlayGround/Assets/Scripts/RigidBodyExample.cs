using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 500f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
