using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DialogueSet : MonoBehaviour // 저장된 TextData에서 데이터를 들고와 
                                                                    // 출력할 준비하는 역할
{
    public DialogueTextData textData;

    private void Start()
    {
        textData = GameObject.Find("DialogueTextData").GetComponent<DialogueTextData>();
    }

    public void SetText(int index)
    {
        var system = GameObject.Find("DialogueSystem").GetComponent<DialogueSystem>();

        var data = JsonUtility.FromJson<Dialogue>(File.ReadAllText(textData.jsonPath[index]));
        system.DialogueBegin(data);
    }
}
