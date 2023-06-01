using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    private int scene = 0;
    public SpriteRenderer spriteFadeIn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Back to menu
        if (collision.CompareTag("Player"))
        {
            SceneTransition();
        }
    }

    public void SceneTransition()
    {
        spriteFadeIn.DOFade(1, 1).OnComplete(() =>
        {
            SceneManager.LoadScene(scene);
        });
    }
}

