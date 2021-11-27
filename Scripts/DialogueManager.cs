using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Queue<string> dialogues;
    public Text speakerName;
    public Text speakerDialogue;
    private string sentence;
    void Start()
    {

    }

    public void StartDialogue(Dialogues d)
    {
        dialogues = new Queue<string>();
        speakerName.text = d.name;
        dialogues.Clear();
        foreach (string s in d.sentences)
        {
            dialogues.Enqueue(s);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(dialogues.Count == 0)
        {
            ObjectiveList.objectiveNum++;
            EndDialogue();
            return;
        }
        sentence = dialogues.Dequeue();
        StopAllCoroutines();
        StartCoroutine(Talking(sentence));
    }

    IEnumerator Talking(string sentence)
    {
        speakerDialogue.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            speakerDialogue.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        speakerName.text = "";
        speakerDialogue.text = "";
    }

    public int diagLeft()
    {
        return dialogues.Count;
    }
}
