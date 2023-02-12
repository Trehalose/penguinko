using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    private TMP_Text score;
    private int amount;
    
    void Start()
    {
        score = GetComponent<TMP_Text>();
        amount = 0;
    }

    void Update()
    {
        score.text = amount.ToString();
    }

    public void updateScore(int newScore = 0) {
        amount = newScore;
    }
}
