using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMove : MonoBehaviour
{
      public BoxCollider2D bct; 
     public TrashMove trash;

     
     
    private void Awake(){
        bct=GetComponent<BoxCollider2D>();
        bct.isTrigger = true;
    }
  
    public void OpenDoor(){
        gameObject.SetActive(false) ;
    }

    public void CloseDoor(){
        gameObject.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D other){
        if(Input.GetKeyDown(KeyCode.G) && other.CompareTag("Player")){
            trash.OpenDoor();
           
        }
        
    }

}
