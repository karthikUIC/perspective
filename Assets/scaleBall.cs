using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleBall : MonoBehaviour
{

    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x + (Time.deltaTime * speed), transform.localScale.y + (Time.deltaTime * speed) , transform.localScale.z + (Time.deltaTime * speed));
    }
}
