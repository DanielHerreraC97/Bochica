using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueIndigenous : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;

    public string[] dialogueLines;
    private int index;
    public float wordSpeed;
    public bool playerIsClosed;
    private bool isGetCum = false;

    private void Update()
    {
        //Show dialogue
        if(Input.GetKeyDown(KeyCode.Space) && playerIsClosed && !isGetCum)
        { 
           if(dialoguePanel.activeInHierarchy) 
           {
                zeroText();
           }
           else
           {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());  
           }
        }
    }
    public void zeroText() 
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }
    //Write words
    IEnumerator Typing()
    {
        isGetCum = true;
        foreach(char letter in dialogueLines[index])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
        isGetCum = false;
    }
    //Next line in dialogue
    public void NextLine()
    {
        if(index < dialogueLines.Length -1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText() ;
        }
    }
    //Player near
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerIsClosed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClosed = false;
            zeroText();
        }
    }
}