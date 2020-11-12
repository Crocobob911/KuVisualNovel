using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem: MonoBehaviour
{
    public Text txtName;
    public Text txtSentence;

    Queue<string> names = new Queue<string>();
    Queue<string> sentences = new Queue<string>();

    public void DialogueBegin(Dialogue info)
    {
        sentences.Clear();

        foreach (var name in info.names)
        {
            names.Enqueue(name);
        }
        foreach (var sentence in info.sentences)
        {
            sentences.Enqueue(sentence);
        }
        Debug.Log("Dialogue Began");
    }

    public void DialogueNext()
    {
        txtName.text = names.Dequeue();
        txtSentence.text = sentences.Dequeue();

        Debug.Log("Dialogue Touched");
    }

    public void DialogueEnd()
    {
        Debug.Log("Dialogue Ended");
    }
}
