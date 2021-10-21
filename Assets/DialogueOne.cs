using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueOne : MonoBehaviour
{
    public enum Stages { StageOne, StageTwo, StageThree}
    public Stages myStage = Stages.StageOne;
   
    
    private TMP_Text myText;

    void Awake()
    {
        myText  = GetComponent<TMP_Text>();
    }

    void EnumChange(){

        switch (myStage){

            case Stages.StageOne:
            myText.text = "Hello there strange creature!";
            myStage = Stages.StageTwo;
            break;

            case Stages.StageTwo:
            myText.text = "I assume you are looking for treasure.";
            myStage = Stages.StageThree;
            break;

            case Stages.StageThree:
            myText.text = "Find three fishes, and a portal will appear here.";
            myStage = Stages.StageOne;
            break;

            
        }

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            EnumChange();
        }
    }
}
