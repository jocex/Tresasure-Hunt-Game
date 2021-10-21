using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score;
    public TMP_Text scoreText;
    public GameObject Portal;
    public Score ScoreManager;

    public static void AddToScore(){
        score+= 1;
    }

    public void GoToEnd(){
        Portal.SetActive(true);
    }

    private void Update(){
        scoreText.text="score: " + score;
        if (score > 2){
            ScoreManager.GoToEnd();
        }
    }
}
