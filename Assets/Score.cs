using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score;
    public TMP_Text scoreText;

    public static void AddToScore(){
        score+= 1;
    }

    private void Update(){
        scoreText.text="score: " + score;
    }
}
