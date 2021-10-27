using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanExample : MonoBehaviour
{

    public bool mySwitch = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            mySwitch = true;
        }

        if (Input.GetButtonUp("Jump"))
        {
            mySwitch = !mySwitch;
        } 
    }
}
