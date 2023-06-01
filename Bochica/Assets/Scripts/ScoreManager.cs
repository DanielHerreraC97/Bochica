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
    private int scene = 3;

    private int totalItems = 9; 

    public void Start()
    {
        textItems = GetComponent<TextMeshProUGUI>();
        spriteFadeIn.DOFade(0, 0);
    }

    public void Update()
    {
        //Shows the number of items
        textItems.text = currentScore.ToString("0");
    }

    //Add items
    public void AddItem(int scoreAmmount)
    {
        currentScore += scoreAmmount;
        if (currentScore >= totalItems)
        {
            SceneTransition();
        }
    }
    //Go to end escene
    public void SceneTransition()
    {
        audioMusic.DOFade(0, 3);
        spriteFadeIn.DOFade(1, 2).OnComplete(() =>
        {
            SceneManager.LoadScene(scene);
        });
    }



}
