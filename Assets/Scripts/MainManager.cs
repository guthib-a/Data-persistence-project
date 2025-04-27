using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public string playerName;
    public int playerScore;

    public string playerHighScoreName;
    public int playerHighScore;

    private void Awake()
    {
        //we want to make sure that there is only ever one instance of MainManager
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject); // Makes sure the MainManager GameObject doesn't get destroyed when switching Scenes
        LoadNameAndScore(); // Loads the high score and the name   
    }

    [System.Serializable]
    class SaveData
    {
        public string playerHighScoreName;
        public int playerHighScore;
    }

    public void SaveNameAndScore()
    {
        SaveData data = new SaveData();

        data.playerHighScoreName = playerHighScoreName;
        data.playerHighScore = playerHighScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadNameAndScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerHighScoreName = data.playerHighScoreName;
            playerHighScore = data.playerHighScore;
        }
    }
}

