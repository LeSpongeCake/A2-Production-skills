using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    [SerializeField] private float typingSpeed = 0.05f;

    [SerializeField] private TextMeshProUGUI nPCDialogueText;

    [SerializeField] private string[] nPCDialogueSentences;

    private int nPCindex;

    private void Start()
    {
        StartDialogue();
    }

    public void StartDialogue()
    {
        StartCoroutine(typeNPCDialogue());
    }

    private IEnumerator typeNPCDialogue()
    {
        foreach (char letter in nPCDialogueSentences[nPCindex].ToCharArray())
        {
            nPCDialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        } 
    }
}
