﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RecepDialogue : MonoBehaviour
{
    public GameObject dialogueCanvas;
    public Text dialogue;
    bool timerGoing = false;
    float timer = 0;
    System.Random rnd = new System.Random();
    int rndSuspect;
    List<string> dialogueList = new List<string>();
    void Update()
    {
        if (timerGoing)
        {
            timer += Time.deltaTime;
            if (timer > 3)
            {
                DialogueProgression();
            }
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
        dialogueList.Add("I wasn't even around that night.  I was in Brooklyn, everyone will vouch for me.");
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void Suspects()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        rndSuspect = PlayerPrefs.GetInt("RecepSuspects");
        while (rndSuspect == PlayerPrefs.GetInt("RecepSuspects"))
        {
            rndSuspect = rnd.Next(1, 5);
        }
        if (rndSuspect == 1)
        {
            dialogueList.Add("Oh, definitely not Old Man Wilfred.");
            dialogueList.Add("He gives everyone disapproving looks, except Stephen.");
            dialogueList.Add("He treated Stephen like a grandson.");
        }
        else if (rndSuspect == 2)
        {
            dialogueList.Add("Oh, definitely not Gregory.");
            dialogueList.Add("I don't think he even knew who Stephen was, since Greg never leaves his room.");
        }
        else if (rndSuspect == 3)
        {
            dialogueList.Add("Oh, definitely not Tracy.");
            dialogueList.Add("She loved Stephen a whole lot, nothing could seperate those two.");
        }
        else
        {
            dialogueList.Add("Oh, definitely not Kevin, my manager.");
            dialogueList.Add("He loves hotel publicity, but this is not the right kind of publicity.");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void DialogueProgression()
    {
        if (dialogueList.Count == 0)
        {
            PlayerPrefs.SetInt("CanMove?", 1);
            timerGoing = false;
            timer = 0;
            dialogue.text = "";
        }
        else
        {
            timer = 0;
            dialogueList.RemoveAt(0);
        }
        dialogue.text = dialogueList[0];
    }
}