using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LoadIntro : MonoBehaviour
{
    public SpriteRenderer sprite;
    public AudioSource audioMusic;
    public void ChangeScene()
    {
        Camera.main.DOOrthoSize(-0.8f, 5);
        audioMusic.DOFade(0, 5);
        sprite.DOFade(1, 5).OnComplete(() =>
        {
            SceneManager.LoadScene("Introduction");
        });
    }
}
