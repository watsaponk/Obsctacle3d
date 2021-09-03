using System;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    [SerializeField] private Text textScore;
    
    private int totalScore = 0;
    
    private void Start()
    {
        totalScore = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        totalScore++;
        textScore.text = totalScore.ToString();
    }
}