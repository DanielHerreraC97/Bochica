using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour 
{
    static int currentScore;
    static int endScore;
    public TextMeshProUGUI textItems;

    public void Start()
    {
        textItems = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        textItems.text = currentScore.ToString("0");
    }
    //Puntutación Inicial y Final
    public static void SetValues(int newCurrentScore, int newEndScore)
    {
        currentScore = newCurrentScore;
        endScore = newEndScore;
    }

    //Sumar puntos
    public static void AddScore(int scoreAmmount)
    {
        if(currentScore + scoreAmmount >= endScore)
        {
            currentScore = endScore;
            Debug.Log("Congratulations!");
        }
        else
        {
            currentScore += scoreAmmount;
            Debug.Log(scoreAmmount);
        }
    
    }
    
}
