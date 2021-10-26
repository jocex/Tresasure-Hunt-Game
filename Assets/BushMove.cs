using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushMove : MonoBehaviour
{
    public Sprite NewSprite;
    public BoxCollider2D bush;
    bool inBush;

    private void Awake(){
        bush=GetComponent<BoxCollider2D>();
        bush.isTrigger = true;
    }
     public void OpenBush(){
        gameObject.SetActive(false) ;
    }
    public void Update(){
        if(Input.GetKeyDown(KeyCode.G) && inBush == true){
            OpenBush();
        }
    }

       void OnTriggerEnter2D(Collider2D other){
        if( other.CompareTag("Player")){
            inBush = true;
            
           
           
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if( other.CompareTag("Player")){
        inBush = false;
        }
    }
}
