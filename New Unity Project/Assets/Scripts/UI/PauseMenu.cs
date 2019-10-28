using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                GetComponent<Canvas>().enabled = true;
            }
            else
            {
                Time.timeScale = 1;
                GetComponent<Canvas>().enabled = false;
            }
        }
    }

    public void Resume()
    {
    Time.timeScale = 1;
    GetComponent<Canvas>().enabled = false;
    }
    
    public void LoadMainMenu()
    {
    Time.timeScale = 1;
    SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}