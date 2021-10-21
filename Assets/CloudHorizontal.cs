using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudHorizontal : MonoBehaviour
{
    public float cloudSpeed = 8.0f;
    public float cloudX = 1.0f;
    bool moveRight = true;

   
    void Update()
    {
        if(transform.position.x >10){
            moveRight = false;
        }
        if(transform.position.x < -11){
            moveRight = true;
        }

        if(moveRight == true){
            transform.position = new Vector2(transform.position.x + cloudSpeed * cloudX,transform.position.y);
        }
        if(moveRight == false){
            transform.position = new Vector2(transform.position.x - cloudSpeed * cloudX,transform.position.y);
        }

        
    }
}
