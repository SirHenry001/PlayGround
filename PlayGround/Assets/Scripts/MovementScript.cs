using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float hor = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * hor * speed * Time.deltaTime);
    }
}
