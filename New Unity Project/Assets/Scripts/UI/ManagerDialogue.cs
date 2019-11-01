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
        PlayerPrefs.SetInt("CanOffice", 1);
        timer = 0;
        timerGoing = true;
        dialogueList.Add("Oh, of course.");
        dialogue.text = dialogueList[0];
    }
    public void DialogueProgression()
    {
        /*if (timer > 3 && dialogueList.Count == 1)
        {
            PlayerPrefs.SetInt("CanMove?", 1);
            timerGoing = false;
            timer = 0;
            dialogue.text = "";
        }
        else if (timer > 3)
        {
            timer = 0;
            dialogueList.RemoveAt(0);
        }*/
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
