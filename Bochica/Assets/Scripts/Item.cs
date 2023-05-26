using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    int items = 1;
    public AudioSource pickUpSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Pick up item
        if (collision.CompareTag("Player"))
        {
            pickUpSound.Play();
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.AddItem(items);
            Destroy(this.gameObject);
        }
    }
}
