using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Net.Cache;

public class PlayerController : MonoBehaviour
{
    public PlayerData playerData;

    private void Start()
    {

    }


}

[System.Serializable]
public class PlayerData
{
    public string name;
    public int age;
    public bool isDead;
}
