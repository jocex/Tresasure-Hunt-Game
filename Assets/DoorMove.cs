using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{   
    
    public BoxCollider2D bc; 
     public DoorMove door;

     
     
    private void Awake(){
        bc=GetComponent<BoxCollider2D>();
        bc.isTrigger = true;
    }
  
    public void OpenDoor(){
        gameObject.SetActive(false) ;
    }

    public void CloseDoor(){
        gameObject.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D other){
        if(Input.GetKeyDown(KeyCode.G) && other.CompareTag("Player")){
            door.OpenDoor();
            Score.AddToScore();
           
        }
        
    }


    
        
    
}
