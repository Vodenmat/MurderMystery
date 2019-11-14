using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StephenDialogue : MonoBehaviour
{
    public GameObject dialogueCanvas;
    public Text dialogue;
    public GameObject blackOut;
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
    public void Manager()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        dialogueList.Add("I don't know...");
        rndSuspect = rnd.Next(1, 4);
        if (PlayerPrefs.GetInt("Murderer") == 4 && (rndSuspect == 1 || rndSuspect == 2))
        {
            dialogueList.Add("I think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") == 4 && rndSuspect == 3)
        {
            dialogueList.Add("I don't think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") != 4 && rndSuspect == 1)
        {
            dialogueList.Add("I think so...?");
        }
        else
        {
            dialogueList.Add("I don't think so...?");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void Celebrity()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        dialogueList.Add("I don't know...");
        rndSuspect = rnd.Next(1, 4);
        if (PlayerPrefs.GetInt("Murderer") == 2 && (rndSuspect == 1 || rndSuspect == 2))
        {
            dialogueList.Add("I think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") == 2 && rndSuspect == 3)
        {
            dialogueList.Add("I don't think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") != 2 && rndSuspect == 1)
        {
            dialogueList.Add("I think so...?");
        }
        else
        {
            dialogueList.Add("I don't think so...?");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void Nerd()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        dialogueList.Add("I don't know...");
        rndSuspect = rnd.Next(1, 4);
        if (PlayerPrefs.GetInt("Murderer") == 1 && (rndSuspect == 1 || rndSuspect == 2))
        {
            dialogueList.Add("I think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") == 1 && rndSuspect == 3)
        {
            dialogueList.Add("I don't think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") != 1 && rndSuspect == 1)
        {
            dialogueList.Add("I think so...?");
        }
        else
        {
            dialogueList.Add("I don't think so...?");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void OldMan()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        dialogueList.Add("I don't know...");
        rndSuspect = rnd.Next(1, 4);
        if (PlayerPrefs.GetInt("Murderer") == 3 && (rndSuspect == 1 || rndSuspect == 2))
        {
            dialogueList.Add("I think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") == 3 && rndSuspect == 3)
        {
            dialogueList.Add("I don't think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") != 3 && rndSuspect == 1)
        {
            dialogueList.Add("I think so...?");
        }
        else
        {
            dialogueList.Add("I don't think so...?");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void Receptionist()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        dialogueList.Add("I don't know...");
        rndSuspect = rnd.Next(1, 4);
        if (PlayerPrefs.GetInt("Murderer") == 5 && (rndSuspect == 1 || rndSuspect == 2))
        {
            dialogueList.Add("I think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") == 5 && rndSuspect == 3)
        {
            dialogueList.Add("I don't think so...?");
        }
        else if (PlayerPrefs.GetInt("Murderer") != 5 && rndSuspect == 1)
        {
            dialogueList.Add("I think so...?");
        }
        else
        {
            dialogueList.Add("I don't think so...?");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void DialogueProgression()
    {
        if (dialogueList.Count == 1)
        {
            timerGoing = false;
            timer = 0;
            dialogue.text = "";
            dialogueList.RemoveAt(0);
            //GameObject fade = Instantiate(blackOut, new Vector3(-3.91f, 8.4f, 0), Quaternion.identity);
            blackOut.GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log(PlayerPrefs.GetInt("Alive?"));
        }
        else
        {
            timer = 0;
            dialogueList.RemoveAt(0);
        }
        dialogue.text = dialogueList[0];
    }
}