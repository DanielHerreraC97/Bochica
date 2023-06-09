using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NShake : MonoBehaviour
{
    public float duration = 1.0f;
    public bool start = false;
    public AnimationCurve curve;
    void Start()
    {
        
    }

    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime/duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            yield return null;

        }

        transform.position = startPosition;
    }

        

        private void Update()
    {
        if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
        
    }

}

