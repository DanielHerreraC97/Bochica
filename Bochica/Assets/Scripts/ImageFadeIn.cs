using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ImageFadeIn : MonoBehaviour
{
    public float fadeInDuration = 1f;
    public float fadeOutDuration = 1f;
    public float fadeDelay = 0f;

    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();

        
        Color spriteColor = image.color;
        spriteColor = new Color(spriteColor.r, spriteColor.g, spriteColor.b, 0f);
        image.color = spriteColor;

        
        image.DOFade(1f, fadeInDuration);

        
        if (fadeOutDuration > 0f)
        {
            image.DOFade(0f, fadeOutDuration).SetDelay(fadeDelay + fadeInDuration);
        }
    }
}
