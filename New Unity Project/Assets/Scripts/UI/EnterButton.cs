﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EnterButton : MonoBehaviour
{
    public Text buttonWarningText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnterButtonClick()
    {
        
        if (PlayerPrefs.GetInt("EnterRoom#") == 1 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            SceneManager.LoadScene("YourRoom");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 3 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            SceneManager.LoadScene("OldManRoom");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 2 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            SceneManager.LoadScene("StephenRoom");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 5 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            SceneManager.LoadScene("NerdRoom");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 6 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            SceneManager.LoadScene("CelebRoom");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 7 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            SceneManager.LoadScene("Office");
        }
        PlayerPrefs.SetInt("PlayerKnowsCost", 1);
        buttonWarningText.text = "Are you sure?  This will cost you an action.";
    }
}
