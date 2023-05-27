using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FadeOutScene2 : MonoBehaviour
{
    public SpriteRenderer spriteFadeOut;
    void Start()
    {
        spriteFadeOut.DOFade(0, 2);
    }

    
}
