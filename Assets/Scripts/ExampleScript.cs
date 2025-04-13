using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Xml.Linq;
using System.IO;
public class ExampleScript : MonoBehaviour
{
    public GameObject register_username;
    public string name;
    private void Update()
    {
        name = register_username.GetComponent<TMP_InputField>().text;
        
    }
    
    public class StoreName
    {
        public string Playername;
        public int score;
    }
    public StoreName StoredName = new StoreName();
    

    public void OutputJSON()
    {
        string StoreName_StrOutput = JsonUtility.ToJson(StoredName);
        File.WriteAllText(Application.dataPath + "/text.txt" , StoreName_StrOutput);
    }
}
