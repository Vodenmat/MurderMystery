﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerDialogue : MonoBehaviour
{
    public GameObject dialogueCanvas;
    public GameObject prefab;
    public Text dialogue;
    bool timerGoing = false;
    float timer = 0;
    System.Random rnd;
    List<string> dialogueList = new List<string>();
    void Update()
    {
        if (timerGoing && Input.GetMouseButtonDown(0))
        {
            DialogueProgression();
        }
        if (PlayerPrefs.GetInt("Actions") == 1 && timerGoing == false && PlayerPrefs.GetString("SpeakingTo") == "Manager")
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            dialogueCanvas.GetComponent<Canvas>().enabled = true;
            dialogue.text = "Well, it's gotten late.";
            GameObject fade = Instantiate(prefab, new Vector3(0,0,0), Quaternion.identity);
            timerGoing = true;
        }
    }
    public void Cancel()
    {
        GetComponent<Canvas>().enabled = false;
        PlayerPrefs.SetInt("CanMove?", 1);
    }
    public void WhereYou()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        dialogueList.Add("In my office, filing some paperwork for our hotel taxes");
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void Suspects() //Takes an action
    {
        timerGoing = true;
        PlayerPrefs.SetInt("Actions", PlayerPrefs.GetInt("Actions") - 1);
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        if (PlayerPrefs.GetInt("ManagerSuspects") == 1)
        {
            dialogueList.Add("Well, I'm not sure if I'm allowed to have an opinion here...");
            dialogueList.Add("but I'd watch out for Gregory.");
            dialogueList.Add("He just sits in his room, hating social situations.");
        }
        else if (PlayerPrefs.GetInt("ManagerSuspects") == 2)
        {
            dialogueList.Add("Well, I'm not sure if I'm allowed to have an opinion here...");
            dialogueList.Add("but I'd watch out for Old Man Wilfred.");
            dialogueList.Add("I don't even know what he does all day, he just lurks around.");
        }
        else if (PlayerPrefs.GetInt("ManagerSuspects") == 3)
        {
            dialogueList.Add("Well, I'm not sure if I'm allowed to have an opinion here...");
            dialogueList.Add("But I'd watch out for Tracy.");
            dialogueList.Add("She was in his room the night of the murder...");
            dialogueList.Add("But she says she didn't see anything.");
        }
        else
        {
            dialogueList.Add("Well, I'm not sure if I'm allowed to have an opinion here...");
            dialogueList.Add("But I'd watch out for Cheryl, my receptionist.");
            dialogueList.Add("She was Stephen's ex.  Simple as that.");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
    }
    public void OfficeAsk()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        timer = 0;
        timerGoing = true;
        if (PlayerPrefs.GetInt("CanOffice") == 1)
        {
            dialogueList.Add("But, you-");
        }
        else
        {
            dialogueList.Add("Oh, of course.");
        }
        PlayerPrefs.SetInt("CanOffice", 1);
        dialogue.text = dialogueList[0];
    }
    public void DialogueProgression()
    {
        if (dialogueList.Count == 1)
        {
            PlayerPrefs.SetInt("CanMove?", 1);
            timerGoing = false;
            timer = 0;
            dialogue.text = "";
            dialogueList.RemoveAt(0);
        }
        else
        {
            timer = 0;
            dialogueList.RemoveAt(0);
        }
        dialogue.text = dialogueList[0];
    }
}
