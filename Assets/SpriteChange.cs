using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite NewSprite;
    public BoxCollider2D ss;
    bool inSaw; 

    private void Awake(){
    ss=GetComponent<BoxCollider2D>();
    ss.isTrigger = true;
    }

    void SeesawMove(){
        gameObject.GetComponent<SpriteRenderer>().sprite = NewSprite;
    }


    void Update()
    {
         if(Input.GetKeyDown(KeyCode.G) && inSaw == true){
            SeesawMove();
        }
    }
      void OnTriggerEnter2D(Collider2D other){
        if( other.CompareTag("Player")){
            inSaw = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if( other.CompareTag("Player")){
            inSaw = false;
        }
    }
}
