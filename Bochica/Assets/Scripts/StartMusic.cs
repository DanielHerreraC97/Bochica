using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    private int delay = 3;
    private AudioSource audioSource;
    
    void Start()
    {
       Invoke("PlayAudio", delay);
    }

  
    void Update()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        
    }

    private void PlayAudio()
    {
        audioSource.Play();
    }
}
