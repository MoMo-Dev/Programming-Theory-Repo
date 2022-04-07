using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Screen : MonoBehaviour
{ 
    public void StartGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: + 1);
    }
    
}
