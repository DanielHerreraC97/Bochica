using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using TMPro;

public class TransitionToLevel : MonoBehaviour
{
    public SpriteRenderer spriteFadeIn;
    public TMP_Text textMeshPro;
    public TMP_Text textMeshPro2;
    public AudioSource audioMusic;
    public int scene;


    void OnEnable()
    {
        audioMusic.DOFade(0, 3);
        textMeshPro.DOFade(0, 3);
        textMeshPro2.DOFade(0, 3);
        spriteFadeIn.DOFade(1, 2).OnComplete(() =>
        {
            SceneManager.LoadScene(scene);
         });
    } 

   
}
