using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
   public float Horizontal = 0.0f;
   public float Vertical = 0.0f;
   float runspeed = 4.0f;
   public Animator animator;

 

   void Start(){
      
       transform.position = new Vector3(0,0,0);
   }

   void MoveObject(){
       
       
       if (Input.GetKey(KeyCode.RightArrow)){
           transform.Translate((Vector2.right *Time.deltaTime)*Horizontal);
       }
       if (Input.GetKey(KeyCode.LeftArrow)){
           transform.Translate((Vector2.left *Time.deltaTime)*Horizontal);
       }
       if (Input.GetKey(KeyCode.DownArrow)){
           transform.Translate((Vector2.down *Time.deltaTime)*Vertical);
       }
       if (Input.GetKey(KeyCode.UpArrow)){
           transform.Translate((Vector2.up *Time.deltaTime)*Vertical);
       }
   }

   void Update(){
       MoveObject();
       Horizontal = Input.GetAxisRaw("Horizontal") * runspeed;
       Vertical = Input.GetAxisRaw("Vertical") * runspeed;
       animator.SetFloat("Horizontal", Mathf.Abs(runspeed));
       animator.SetFloat("Vertical", Mathf.Abs(runspeed));

       if (transform.position.y>6){
           transform.position = new Vector3(transform.position.x,6,0);
       }
       if (transform.position.y <-18){
           transform.position = new Vector3(transform.position.x,-18,0);
       }
       if (transform.position.x>28){
           transform.position = new Vector3(28,transform.position.y,0);
       }
        if (transform.position.x<-29){
           transform.position = new Vector3(-29,transform.position.y,0);
       }
       }
   }

