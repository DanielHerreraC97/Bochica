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
        playerController.MuerteJugador += ActiveMenu;
    }


    private void ActiveMenu(object sender, EventArgs e)
    {
        Invoke("ActivateGameOver", 2.5f);

    }
    private void ActivateGameOver()
    {
        gameOver.SetActive(true);
    }
    void Update()
    {
        if (gameOver.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
