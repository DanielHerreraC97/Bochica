using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class FinalSceneTransition : MonoBehaviour
{
    public SpriteRenderer spriteFadeIn;
    public AudioSource audioMusic;
    private int scene = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneTransition();
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
