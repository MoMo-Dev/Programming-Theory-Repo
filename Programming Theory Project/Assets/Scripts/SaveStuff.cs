using System;
using UnityEngine;
using UnityEngine.UI;

public class SaveStuff : MonoBehaviour
{
    public InputField inputText; 
    string tutorialText;

    private void Start()
    {
        tutorialText = PlayerPrefs.GetString("tutorialTextKeyName");
        inputText.text = tutorialText;
    }

    public void SaveThis()
    {
        tutorialText = inputText.text;
        PlayerPrefs.SetString("tutorialTextKeyName", tutorialText);
        
    }
}
