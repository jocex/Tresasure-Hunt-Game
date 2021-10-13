using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMove : MonoBehaviour
{
      public BoxCollider2D bct; 
     public TrashMove trash;
     bool inTrash;

     
     
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

    void Update(){
        if(Input.GetKeyDown(KeyCode.G) && inTrash == true){
            trash.OpenDoor();
             Score.AddToScore();

        }

    }

    

    private void OnTriggerEnter2D(Collider2D other){
        if( other.CompareTag("Player")){
            inTrash = true;
            
           
           
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if( other.CompareTag("Player")){
        inTrash = false;
        }
    }
}
