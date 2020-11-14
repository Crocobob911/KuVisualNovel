using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class DialogueTextData: MonoBehaviour //파일들에서 텍스트 가져와 저장하는 역할
{
    public List<string> jsonPath = new List<string>();

    private void Start()
    {
        TextLoad();
    }

    public void TextLoad()
    {
        jsonPath.Add(Path.Combine(Application.dataPath, "Json/dummyTextData1.json"));
        jsonPath.Add(Path.Combine(Application.dataPath, "Json/dummyTextData2.json"));
    }
}
