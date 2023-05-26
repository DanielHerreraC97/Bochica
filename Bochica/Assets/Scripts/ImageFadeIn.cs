using UnityEngine;
using DG.Tweening;

public class ImageFadeIn : MonoBehaviour
{
    public float fadeInDuration = 1f;
    public float fadeOutDuration = 1f;
    public float fadeDelay = 0f;

    private SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        
        Color spriteColor = sprite.color;
        spriteColor = new Color(spriteColor.r, spriteColor.g, spriteColor.b, 0f);
        sprite.color = spriteColor;

        
        sprite.DOFade(1f, fadeInDuration);

        
        if (fadeOutDuration > 0f)
        {
            sprite.DOFade(0f, fadeOutDuration).SetDelay(fadeDelay + fadeInDuration);
        }
    }
}
