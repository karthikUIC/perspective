using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSymbol : MonoBehaviour
{
    // Start is called before the first frame update
    private float degreesPerSecond;
    public GameObject webHand;
    public GameObject normalHand;
     public GameObject webHand2;
    public GameObject normalHand2;
    void Start()
    {
        degreesPerSecond = 100;
   
    }

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(new Vector3( 0, 0 , degreesPerSecond) * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other){
        
        if(other.gameObject.tag == "leftController" || other.gameObject.tag == "rightController"){
            Debug.Log("thehand");
            Debug.Log("thehand " + normalHand.name  );
            Debug.Log("thehand " + webHand.name );

            webHand.active = true;
            webHand2.active = true;

            normalHand.active = false;
            normalHand2.active = false;

             Destroy(gameObject);
        }
    }
}
