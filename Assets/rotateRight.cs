using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class rotateRight : MonoBehaviour
{
   public GameObject textHUD;
    public Quaternion startQuaternion;
    public float lerpTime = 1;
    public bool rotateRight1;
    public bool rotateLeft1;
    private GameObject room1;
    private GameObject room2;
    public int currAngle;
    public int toCurrAngle;

   

    // Start is called before the first frame update
    void Start()
    {

        toCurrAngle = 0;
        room1 = GameObject.Find("Room");
        currAngle = 0;
      

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("currAngle currAngle " + toCurrAngle + "  currAngle " + currAngle);
        if(rotateRight1){
               //transform.rotation = Quaternion.Lerp(transform.rotation , Quaternion.Euler(90,90,90) , Time.deltaTime * lerpTime);
            TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            textmeshPro.SetText("rotating right");
            if(toCurrAngle != currAngle){
                currAngle--; 
                room1.transform.rotation = Quaternion.Euler(new Vector3(currAngle, 0f, 0f)); 
            }
        }


        if(rotateLeft1){
               //transform.rotation = Quaternion.Lerp(transform.rotation , Quaternion.Euler(90,90,90) , Time.deltaTime * lerpTime);
            TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            textmeshPro.SetText("rotating left");
            if(toCurrAngle != currAngle){
                currAngle++; 
                room1.transform.rotation = Quaternion.Euler(new Vector3(currAngle, 0f, 0f)); 
            }
        }
     
    }


      private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "leftController" || other.gameObject.tag == "rightController"){
   
        //     rotateRight1 = true;
        //    // currAngle = 0f;
        //     toCurrAngle = toCurrAngle - 90;
             
        //    // toRight = toRight - 90f; 

           rotateRightFun();
        }

    }

    public void rotateRightFun(){
  
            rotateRight1 = true;
            rotateLeft1 = false;
            //currAngle = 0f;
            toCurrAngle = toCurrAngle - 90;
          
           // toRight = toRight - 90f; 
    }


    public void rotateLeftFun1(){
            Debug.Log("left fun1");
            rotateLeft1 = true;
            rotateRight1 = false;
            //currAngle = 0f;
            toCurrAngle = toCurrAngle + 90;
           // toRight = toRight - 90f; 
    }

}
