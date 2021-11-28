using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampLight : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject lampLight1;
    void Start()
    {
        lampLight1 = GameObject.Find("lampLight1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other){
        if (
            other.gameObject.tag == "leftController" ||
            other.gameObject.tag == "rightController"
        )
        {
            lampLight1.active = !lampLight1.active;
            Debug.Log(lampLight1);
        }

    }
}
