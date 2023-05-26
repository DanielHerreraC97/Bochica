using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LoadIntro : MonoBehaviour
{
    public SpriteRenderer sprite;
    void Start()
    {
        
    }

    public void ChangeScene()
    {
        Camera.main.DOOrthoSize(-0.8f, 6);
        sprite.DOFade(1, 6).OnComplete(() =>
        {
            SceneManager.LoadScene("Introduction");
        });
    }
    void Update()
    {
        
    }
}
