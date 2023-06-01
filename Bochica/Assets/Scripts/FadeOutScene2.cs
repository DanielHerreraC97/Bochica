using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class FadeOutScene2 : MonoBehaviour
{
    public SpriteRenderer spriteFadeOut;
    public TMP_Text[] text;
    
    void Start()
    {
        foreach (var item in text)
        { 
            item.DOFade(1, 2);
            spriteFadeOut.DOFade(0, 2);
        }
    }

    
}
