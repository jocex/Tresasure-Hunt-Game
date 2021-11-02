using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rustle : MonoBehaviour
{
    public BoxCollider2D box;
    public AudioSource rustle;
    bool inDabush;

    private void Awake(){
        box=GetComponent<BoxCollider2D>();
        box.isTrigger = true;
    }

    void Update()
    { 
        if(inDabush == true){
            if(!rustle.isPlaying){
                rustle.Play();
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if( other.CompareTag("Player")){
            inDabush = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if( other.CompareTag("Player")){
        inDabush = false;
        }
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
}

