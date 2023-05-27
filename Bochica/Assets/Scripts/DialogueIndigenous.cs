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
   // public GameObject contButton;

    public string[] dialogueLines;
    private int index;
    public float wordSpeed;
    public bool playerIsClosed;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerIsClosed)
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

    IEnumerator Typing()
    {
        foreach(char letter in dialogueLines[index])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
     //   contButton.SetActive(false);

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
