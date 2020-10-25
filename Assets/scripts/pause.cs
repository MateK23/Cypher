using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pausemenuUI;
    void Start()
    {
       
        isPaused = false;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {


            if (isPaused)
            {
                resume();
            }
            else
            {
                pausee();
            }

        }
    }
    public void resume()
    {


        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

       
    }

    public void pausee()
    {

        pausemenuUI.SetActive(true);
       
        Time.timeScale = 0f;
        isPaused = true;
    }
   
    public void quite()
    {
        Application.Quit();
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

   
}

