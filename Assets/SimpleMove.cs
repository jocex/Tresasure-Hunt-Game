using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
   public float speed = 2.0f;

   void Start(){
       transform.position = new Vector3(0,0,0);
   }

   void MoveObject(){
       if (Input.GetKey(KeyCode.RightArrow)){
           transform.Translate((Vector2.right *Time.deltaTime)*speed);
       }
       if (Input.GetKey(KeyCode.LeftArrow)){
           transform.Translate((Vector2.left *Time.deltaTime)*speed);
       }
       if (Input.GetKey(KeyCode.DownArrow)){
           transform.Translate((Vector2.down *Time.deltaTime)*speed);
       }
       if (Input.GetKey(KeyCode.UpArrow)){
           transform.Translate((Vector2.up *Time.deltaTime)*speed);
       }
   }

   void Update(){
       MoveObject();
   }
}
