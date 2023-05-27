using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour 
{
    public int currentScore;
    public TextMeshProUGUI textItems;

    public SpriteRenderer spriteFadeIn;
    public AudioSource audioMusic;
    public int scene;
    private int totalItems = 9; 

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
        if(currentScore >= totalItems)
        {
            // currentScore += scoreAmmount;
            SceneTransition();
            Debug.Log("Congratulations!");
        }
        else
        {
            currentScore += scoreAmmount;
        }
    }

    public void SceneTransition()
    {
        audioMusic.DOFade(0, 3);
        spriteFadeIn.DOFade(1, 2).OnComplete(() =>
        {
            SceneManager.LoadScene(scene);
        });
    }



}
