using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoadPrac : MonoBehaviour
{
    private PlayerData data;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SavePlayerDataToJson();
            Debug.Log("Saved");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            LoadPlayerDataFromJson();
            Debug.Log("Loaded");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(data.name);
            Debug.Log(data.age);
            Debug.Log(data.isDead);
        }
    }

    [ContextMenu("To Json Data")]
    void SavePlayerDataToJson()
    {
        string jsonData = JsonUtility.ToJson(data, true);
        string path = Path.Combine(Application.dataPath, "playerData.json");
        File.WriteAllText(path, jsonData);
    }

    [ContextMenu("From Json Data")]
    void LoadPlayerDataFromJson()
    {
        string path = Path.Combine(Application.dataPath, "playerData.json");
        string jsonData = File.ReadAllText(path);
        data = JsonUtility.FromJson<PlayerData>(jsonData);
    }
}


[System.Serializable]
public class PlayerData
{
    public int age;
    public bool isDead;
    public string name;
}
