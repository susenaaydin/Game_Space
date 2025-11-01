using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI ScoreText;

    
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
    }

    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();


    }
}
