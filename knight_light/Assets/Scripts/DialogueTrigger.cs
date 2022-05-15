using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue1;
    public Dialogue dialogue2;
    public Dialogue dialogue3;
    public Dialogue dialogue4;
    public Dialogue dialogue5;
    public Dialogue dialogue6;
    public Dialogue dialogue7;
    public Dialogue dialogue8;
    public Dialogue dialogue9;
    private Dialogue[] story;

    private bool isFirst = true;
    public int currentDialogue = 0;

    void Start()
    {
        story = new Dialogue[9];
        story[0] = dialogue1;
        story[1] = dialogue2;
        story[2] = dialogue3;
        story[3] = dialogue4;
        story[4] = dialogue5;
        story[5] = dialogue6;
        story[6] = dialogue7;
        story[7] = dialogue8;
        story[8] = dialogue9;
    }

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
        FindObjectOfType<DialogueManager>().StartDialogue(story[currentDialogue]);
    }
    public void TriggerNextDialogue()
    {
        if (!FindObjectOfType<DialogueManager>().isDone)
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
        else if(currentDialogue < 8 && FindObjectOfType<DialogueManager>().isDone)
        {
            currentDialogue++;
            FindObjectOfType<DialogueManager>().StartDialogue(story[currentDialogue]);
        }else if(currentDialogue == 8)
        {
            FindObjectOfType<DialogueManager>().EndDialogue();
        }
    }
}
