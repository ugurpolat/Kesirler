using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelManager : MonoBehaviour
{
    public int buildIndex = 0;
    private void Start()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;

    }
    public void NextLevel()
    {
        int saveIndex = PlayerPrefs.GetInt("SaveIndex");
        if (buildIndex > saveIndex)
        {
            PlayerPrefs.SetInt("SaveIndex", buildIndex);
        }
        


        if (buildIndex ==10)
        {
            SceneManager.LoadScene(11);
        }
        else
        {
            SceneManager.LoadScene(buildIndex + 1);    
        }
        
    }
}
