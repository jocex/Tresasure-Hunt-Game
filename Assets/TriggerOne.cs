using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOne : MonoBehaviour
{
    public BoxCollider2D bc;
    public Vector3 myVector;
    public Transform cam1;
    
    // Start is called before the first frame update
    void Awake()
    {
        bc = GetComponent<BoxCollider2D>();
        bc.isTrigger = true;
    }

   void OnTriggerEnter2D(Collider2D collision){
       if(collision.CompareTag("Player")){
           cam1.transform.position = cam1.position+myVector;
       }
   }
}
