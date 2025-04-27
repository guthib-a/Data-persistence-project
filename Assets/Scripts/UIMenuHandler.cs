using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]

public class UIMenuHandler : MonoBehaviour
{
    public string inputName;

    public void ReadStringInput(string s) // This turns whatever's written in the InputField into a string
    {
        inputName = s;
        MainManager.Instance.playerName = inputName; // And sets the playerName (from MainManager script) to the string
    }
    public void StartNew() // Loads the next Scene
    {
        SceneManager.LoadScene(1);
    }

    public void Exit() // Quits the game
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}

