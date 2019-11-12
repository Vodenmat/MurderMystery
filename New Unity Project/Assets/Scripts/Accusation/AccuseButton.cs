using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AccuseButton : MonoBehaviour
{
    public Text warningText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick()
    {
        if (warningText.text == "")
        {
            warningText.text = "Are you sure?";
        }
        else
        {
            if (PlayerPrefs.GetInt("Suspect") == PlayerPrefs.GetInt("Murderer"))
            {
                SceneManager.LoadScene("WinScene");
            }
            else
            {
                SceneManager.LoadScene("Lose Scene");
            }
        }
    }
}
