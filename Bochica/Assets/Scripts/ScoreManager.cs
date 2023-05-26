using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour 
{
    public int currentScore;
    public TextMeshProUGUI textItems;

    public void Start()
    {
        textItems = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        //Shows the number of items
        textItems.text = currentScore.ToString("0");
    }

    //Add items
    public void AddItem(int scoreAmmount)
    {
        if(currentScore ==  9)
        {
            currentScore += scoreAmmount;
            Debug.Log("Congratulations!");
        }
        else
        {
            currentScore += scoreAmmount;
        }
        
    }

}
