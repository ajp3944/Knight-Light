using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private bool isFirst = true;

    void Update()
    {
        if (Input.GetButtonDown("Submit") && isFirst)
        {
            TriggerDialogue();
            isFirst = false;
        }else if(Input.GetButtonDown("Submit") && !isFirst)
        {
            TriggerNextDialogue();
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
    public void TriggerNextDialogue()
    {
        FindObjectOfType<DialogueManager>().DisplayNextSentence();
    }
}
