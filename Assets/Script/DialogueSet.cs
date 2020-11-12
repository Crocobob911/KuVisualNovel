using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DialogueSet : MonoBehaviour
{
    public Dialogue data;
    public DialogueTrigger trigger;


    [ContextMenu("Load Text")]
    void LoadPlayerDataFromJson()
    {
        string path = Path.Combine(Application.dataPath, "dummyTextData.json");
        string jsonData = File.ReadAllText(path);
        data = JsonUtility.FromJson<Dialogue>(jsonData);

        trigger.info = data;
    }
}
