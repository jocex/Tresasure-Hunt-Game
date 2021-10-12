using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockMove : MonoBehaviour
{
      public BoxCollider2D bco; 
      public GameObject fishcover;
      public DockMove dock;


     
     
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

    private void OnTriggerStay2D(Collider2D other){
        if(Input.GetKeyDown(KeyCode.G) && other.CompareTag("Player")){
            dock.OpenDock();
            Score.AddToScore();
        }
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
}
