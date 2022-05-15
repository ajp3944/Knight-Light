using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{

    public Queue<string> sentences;
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public Animator animator;
    public bool isDone;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        isDone = false;
        nameText.text = dialogue.name;
        sentences.Clear();
        Debug.Log("QUEUE");

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 1)
        {
            isDone = true;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void EndDialogue()
    {
        Debug.Log("The End");
        animator.SetBool("IsOpen", false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
