using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: + 1);
    }
    
}
