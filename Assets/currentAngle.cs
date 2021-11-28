using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class currentAngle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cv;
   //  public Rigidbody rb;
     public GameObject textHUD;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("xxx " + transform.rotation.x);
          Debug.Log("yyy " + transform.rotation.y);
            Debug.Log("zzz " + transform.rotation.z);
            //  cv.GetComponent<ConstantForce>().AddForce

            //cv.GetComponent<ConstantForce>().force.Set(transform.rotation.x * 3, transform.rotation.y * 3, transform.rotation.z * 3);


           TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            textmeshPro.SetText(transform.rotation.x * 10f + "   " + transform.rotation.y * 10f + "   " + transform.rotation.z * 10f + "   " + ForceMode.Acceleration);
            //rb = cv.GetComponent<Rigidbody>();
           //  rb.AddForce(transform.rotation.x * 10f , transform.rotation.y * 10f, transform.rotation.z * 10f, ForceMode.Acceleration);
            cv.transform.position = new Vector3(transform.position.x + (transform.rotation.x * 0.01f) , transform.position.x + (transform.rotation.y * 0.01f) , transform.position.x + (transform.rotation.z * 0.01f) );
    }
}
