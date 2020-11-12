using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue info;

    private void Start()
    {
        DialTrigger();
    }

    public void DialTrigger()
    {
        var system = FindObjectOfType<DialogueSystem>();
        system.DialogueBegin(info);
        Debug.Log("Dial Triggered");


    }
}
