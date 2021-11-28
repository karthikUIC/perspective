using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class rotateLeft : MonoBehaviour
{
   public GameObject textHUD;
    public Quaternion startQuaternion;
    public float lerpTime = 1;
    public bool rotateLeft1;
    private GameObject room1;
    private GameObject room2;
    private float left;
    private float toLeft;
    public GameObject currState;
    rotateRight otherState;

    // Start is called before the first frame update
    void Start()
    {


        room1 = GameObject.Find("Room");
        
        left = 0f;
        toLeft = 0f;

    }

    // Update is called once per frame
    void Update()
    {
    //         public int currAngle;
    // public int toCurrAngle;
      //  otherState = currState.GetComponent <rotateRight> ();
      //  Debug.Log("script 22!! " + otherState.toCurrAngle + " toCurrAngle  "  + otherState.currAngle +  "  currAngle  script 1 rotation value");
        if(rotateLeft1){
               //transform.rotation = Quaternion.Lerp(transform.rotation , Quaternion.Euler(90,90,90) , Time.deltaTime * lerpTime);
            TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            textmeshPro.SetText("rotating left");
            if(toLeft != left){
                left++; 
                room1.transform.rotation = Quaternion.Euler(new Vector3(left, 0f, 0f)); 
            }
        }
     
    }


      private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "leftController" || other.gameObject.tag == "rightController"){
            currState.GetComponent<rotateRight>().rotateLeftFun1();
     
                // rotateLeft1 = true;
                // left = 0f;
                // toLeft = toLeft + 90;
            
           // toLeft = toLeft + 90f; 
        }

    }


      public void rotateLeftFun(){
          
                rotateLeft1 = true;
                left  = 0f;
                toLeft = toLeft + 90;
                
           // toLeft = toLeft + 90f; 
    }

}
