using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public float moveSpeed = 7.0f;
    public float jumpPower = 7.0f;

    bool isGrounded = false;
    bool canJump = false;
    
    float moveX = 1.0f;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void PlayerControls(){
        if(Input.GetKeyDown(KeyCode.Space)){
            canJump = true;
        }
       

        moveX = 0.0f;
        if(Input.GetKey(KeyCode.LeftArrow)){
            moveX += 1;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            moveX -= 1;
        }
    }

    void move(){
        rb.AddForce(Vector2.left * moveX * moveSpeed);
    }

    void Jump(){
       
      if(canJump == true && isGrounded == true){
        rb.AddForce (Vector2.up * jumpPower, ForceMode2D.Impulse);
        isGrounded = false;
        canJump = false;
      }
    }

   private void OnCollisionEnter2D(Collision2D other){
       if( other.gameObject.tag.Equals("Floor") == true){
           isGrounded = true;
           Debug.Log("jumper");
        }
        else{
            isGrounded = false;
        }
       
   }

    private void FixedUpdate(){
        Jump();
        move();
    }

    void Update(){
        PlayerControls();
    }
}


