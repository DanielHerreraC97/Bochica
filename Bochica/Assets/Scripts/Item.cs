using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    int items = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Pglo");
            ScoreManager.AddScore(items);
            Destroy(this.gameObject);
        }
    }
}
