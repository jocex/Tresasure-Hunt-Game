using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockMove : MonoBehaviour
{
      public BoxCollider2D bco; 
      public GameObject fishcover;
      public DockMove dock;
      bool inWater;


     
     
    private void Awake(){
        bco=GetComponent<BoxCollider2D>();
        bco.isTrigger = true;
    }
  
    public void OpenDock(){
        fishcover.SetActive(false) ;
    }

    public void CloseDock(){
        fishcover.SetActive(true);
    }

     void Update(){
        if(Input.GetKeyDown(KeyCode.G) && inWater == true){
            OpenDock();
             Score.AddToScore();

        }

    }

    

    private void OnTriggerEnter2D(Collider2D other){
        if( other.CompareTag("Player")){
            inWater = true;
            
           
           
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if( other.CompareTag("Player")){
        inWater = false;
        }
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
}
