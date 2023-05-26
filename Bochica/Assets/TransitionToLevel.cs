using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using TMPro;

public class TransitionToLevel : MonoBehaviour
{
    public SpriteRenderer sprite;
    public TMP_Text textMeshPro;
    public TMP_Text textMeshPro2;

    void OnEnable()
    {
        textMeshPro.DOFade(0, 3);
        textMeshPro2.DOFade(0, 3);
        sprite.DOFade(1, 3).OnComplete(() =>
        {
            SceneManager.LoadScene("Level");
         });
    }

   
}
