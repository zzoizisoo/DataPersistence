using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string userName;
    public string topUserName;
    public int bestScore = 0;

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

    private void Start()
    {
        LoadData();
    }

    public void SetUserName(string text)
    {
        userName = text;
    }

    public void SetBestScore(int score)
    {
        if(bestScore < score)
        {
            bestScore = score;
            topUserName = userName;
        }
    }

    [System.Serializable]
    class Data
    {
        public string topUserName;
        public string username;
        public int bestScore;
    }

    public void SaveData()
    {
        Data data = new Data();
        data.topUserName = topUserName;
        data.username = userName;
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);
            topUserName = data.topUserName;
            userName = data.username;
            bestScore = data.bestScore;
        }
    }
}
