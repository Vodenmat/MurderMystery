using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OldManDialogue : MonoBehaviour
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
        if (timerGoing && Input.GetMouseButtonDown(0))
        {
            DialogueProgression();
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
        dialogueList.Add("...");
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void YouHeard()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        timer = 0;
        timerGoing = true;
        dialogueList.Add("...");
        dialogue.text = dialogueList[0];
    }
    public void Suspects()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        if (PlayerPrefs.GetInt("OldManSuspects") == 2)
        {
            dialogueList.Add("The celebrity.");
        }
        else if (PlayerPrefs.GetInt("OldManSuspects") == 4)
        {
            dialogueList.Add("The Manager.");
        }
        else if (PlayerPrefs.GetInt("OldManSuspects") == 1)
        {
            dialogueList.Add("The nerd.");
        }
        else
        {
            dialogueList.Add("The Receptionist.");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
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