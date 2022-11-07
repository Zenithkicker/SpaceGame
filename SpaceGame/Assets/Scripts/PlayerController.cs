using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float forceAmount;

    [SerializeField]
    float rotationAmount;

    [SerializeField]
    float maxVelocitySqrd;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.forward * forceAmount);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(transform.forward * -forceAmount);
        }
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(transform.right * -rotationAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(transform.right * rotationAmount);
        }

        transform.rotation = Quaternion.LookRotation(rb.velocity);
    }
}
