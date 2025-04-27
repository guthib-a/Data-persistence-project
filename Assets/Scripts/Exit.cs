using UnityEditor;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }


    public void SaveBest()
    {
        MainManager.Instance.SaveNameAndScore();
    }
}