using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerDialogue : MonoBehaviour
{
    public GameObject dialogueCanvas;
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
    public void Suspects()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        if (PlayerPrefs.GetInt("ManagerSuspects") == 1)
        {
            dialogueList.Add("Well, I'm not sure if I'm allowed to have an opinion here, but I'd watch out for Gregory");
            dialogueList.Add("He just sits in his room, hating social situations.");
        }
        else if (PlayerPrefs.GetInt("ManagerSuspects") == 2)
        {
            dialogueList.Add("Well, I'm not sure if I'm allowed to have an opinion here, but I'd watch out for Old Man Wilfred.");
            dialogueList.Add("I don't even know what he does all day, he just lurks around.");
        }
        else if (PlayerPrefs.GetInt("ManagerSuspects") == 3)
        {
            dialogueList.Add("Well, I'm not sure if I'm allowed to have an opinion here, but I'd watch out for Tracy.");
            dialogueList.Add("She was in his room the night of the murder, but she says she didn't see anything.");
        }
        else
        {
            dialogueList.Add("Well, I'm not sure if I'm allowed to have an opinion here, but I'd watch out for Cheryl, my receptionist.");
            dialogueList.Add("She was Stephen's ex.  Simple as that.");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
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
