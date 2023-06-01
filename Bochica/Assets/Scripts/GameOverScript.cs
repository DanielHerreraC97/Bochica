using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    private PlayerController playerController;
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        playerController.muerteJugador += ActiveMenu;
    }

    void Update()
    {
        //Restart game
        if (gameOver.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void ActiveMenu(object sender, EventArgs e)
    {
        Invoke("ActivateGameOver", 2.5f);

    }
    //Active panel game over
    private void ActivateGameOver()
    {
        gameOver.SetActive(true);
    }
    
}
