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
        if (PlayerPrefs.GetInt("EnterRoom#") != 1)
        {
            buttonWarningText.text = "Are you sure?  This will cost you an action.";
        }
        if (PlayerPrefs.GetInt("EnterRoom#") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "You have no reason to go in there.";
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 3 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            PlayerPrefs.SetInt("Actions", PlayerPrefs.GetInt("Actions") - 1);
            SceneManager.LoadScene("OldManRoom");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 2 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            PlayerPrefs.SetInt("Actions", PlayerPrefs.GetInt("Actions") - 1);
            SceneManager.LoadScene("StephenRoom");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 5 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            PlayerPrefs.SetInt("Actions", PlayerPrefs.GetInt("Actions") - 1);
            SceneManager.LoadScene("NerdRoom");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 6 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1 && (PlayerPrefs.GetInt("CanCelebRoom") == 1 || PlayerPrefs.GetInt("Alive?") == 1))
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            PlayerPrefs.SetInt("Actions", PlayerPrefs.GetInt("Actions") - 1);
            SceneManager.LoadScene("CelebRoom");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 6 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1 && PlayerPrefs.GetInt("CanCelebRoom") == 0)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "Sorry, you don't have permission to investigate this room";
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 7 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1 && (PlayerPrefs.GetInt("CanOffice") == 1 || PlayerPrefs.GetInt("Alive?") == 1))
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "";
            PlayerPrefs.SetInt("Actions", PlayerPrefs.GetInt("Actions") - 1);
            SceneManager.LoadScene("Office");
        }
        else if (PlayerPrefs.GetInt("EnterRoom#") == 7 && PlayerPrefs.GetInt("PlayerKnowsCost") == 1 && PlayerPrefs.GetInt("CanOffice") == 0)
        {
            PlayerPrefs.SetInt("PlayerKnowsCost", 0);
            buttonWarningText.text = "Sorry, you don't have permission to investigate this room";
        }
        PlayerPrefs.SetInt("PlayerKnowsCost", 1);
    }
}
