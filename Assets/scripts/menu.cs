using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Text scoring;
  
    void Start()
    {
        scoring.text = playermovement.score.ToString() + "KB";
    }

    public void loadscene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        playermovement.score = 0;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
