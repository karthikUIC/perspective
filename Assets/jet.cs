using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jet : MonoBehaviour
{
    // Start is called before the first frame update

    // public Rigidbody rb;
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }
       
    void FixedUpdate() 
    {
       // Rigidbody.AddForce(transform.forward * thrust);
           rb.AddForce(transform.forward * thrust);
    }

}
