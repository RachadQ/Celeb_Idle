using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    public TextAsset jsonFile;
    // Start is called before the first frame update
    void Start()
    {

        if (jsonFile != null)
        {


            Teams TeamInJson = JsonUtility.FromJson<Teams>(jsonFile.text);
            Debug.LogError("Reached");

            foreach (Player player in TeamInJson.players)
            {
                Debug.Log("Found team: " + player.Name + " " + player.PowerLevel);
            }
        }
        else {
            Debug.LogError("Error: JSON file is null.");
        }
    }

  
}
