using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
      public CapsuleCollider2D cc; 
      public GameObject teleportPortal;
       public string nextScene;
       public AudioSource win;
   
  
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!win.isPlaying){
            win.Play();
        }
        if( other.CompareTag("Player")){
            SceneManager.LoadScene(nextScene);
            
           
           
        }
    }
}
