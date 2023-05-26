using UnityEngine;
using TMPro;
using DG.Tweening;

public class FadeInO : MonoBehaviour
{
    public float fadeInDuration = 1f;
    public float fadeOutDuration = 1f;
    public float fadeDelay = 0f;

    private TMP_Text textMeshPro;

    private void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();

        textMeshPro.alpha = 0f;
       
        textMeshPro.DOFade(1f, fadeInDuration);
       
        if (fadeOutDuration > 0f)
        {            
            textMeshPro.DOFade(0f, fadeOutDuration).SetDelay(fadeDelay + fadeInDuration);
        }
    }
}
