using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string userName;

    private void Awake()
    {
        if(Instance == null) {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }

    public void SetUserName(string text)
    {
        userName = text;
    }
}
