using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeowSound : MonoBehaviour
{
    public AudioSource Meow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            if(!Meow.isPlaying){
                Meow.Play();
              
            }

        }

       // if (Input.GetKeyUp(KeyCode.G)){
           // Meow.Stop();
           
       // }
        
    }
}
