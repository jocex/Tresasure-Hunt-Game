using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{   
    
    public BoxCollider2D bc; 
     public DoorMove door;
     public AudioSource DoorCrash;
     bool inDoor; 

     
     
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

    void Update(){
        if(Input.GetKeyDown(KeyCode.G) && inDoor == true){
            if(!DoorCrash.isPlaying){
                DoorCrash.Play();
              
            }
            OpenDoor();
             Score.AddToScore();

        }

    }

    

    private void OnTriggerEnter2D(Collider2D other){
        if( other.CompareTag("Player")){
            inDoor = true;
            
           
           
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if( other.CompareTag("Player")){
        inDoor = false;
        }
    }
        
    


    
        
    
}
