using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score;
    public TMP_Text scoreText;
    public GameObject Portal;
    public GameObject Fish1;
    public GameObject Fish2;
    public GameObject Fish3;
    public Score ScoreManager;

    public static void AddToScore(){
        score+= 1;
    }

    public void GoToEnd(){
        Portal.SetActive(true);
    }

    private void Update(){
       // scoreText.text="score: " + score;
       if(score == 1){
           Fish1.SetActive(true);
       }
       if(score == 2){
           Fish2.SetActive(true);
       }
       if(score == 3){
           Fish3.SetActive(true);
       }
        if (score > 2){
            ScoreManager.GoToEnd();
        }
    }
}
