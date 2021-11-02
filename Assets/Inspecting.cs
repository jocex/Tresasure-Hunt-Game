using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspecting : MonoBehaviour
{    
    public Sprite InspectingSprite;
    public Sprite Regular;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)){
            gameObject.GetComponent<SpriteRenderer>().sprite = InspectingSprite;
            Debug.Log("Changed");
        }
        if (Input.GetKeyUp(KeyCode.G)){
            gameObject.GetComponent<SpriteRenderer>().sprite = Regular;
            Debug.Log("Regular");
        }
    }
}
