using UnityEngine;
using UnityEngine.UI;

public class SaveDStuff : MonoBehaviour
{
    public  Text tutorialText;

    private void Start()
    {
        tutorialText.text = PlayerPrefs.GetString("tutorialTextKeyName");
    }

   
}