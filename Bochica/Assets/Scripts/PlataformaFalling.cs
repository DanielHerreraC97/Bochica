using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlataformaFalling : MonoBehaviour
{

    public float fallDelay;
    public int requireQuantity;

    private Rigidbody2D rb2d;
    private Collider2D cd2d;
    private ScoreManager scoreManager;

    [SerializeField] private ParticleSystem dustParticle;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        cd2d = GetComponent<Collider2D>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }
    private void FixedUpdate()
    {
        //Valid the require quantity of items for the platform fail
        if (scoreManager.currentScore == requireQuantity)
        {
            Fall();
            dustParticle.Play();
            StartCoroutine(ActiveParticles());
        }
    }
    //Platform Fail
    public void Fall()
    {
     rb2d.isKinematic = false;
     cd2d.isTrigger = true;
    }
    //Active particules
    IEnumerator ActiveParticles()
    {
        yield return new WaitForSeconds(2.7f);
        dustParticle.Clear();
    }
}