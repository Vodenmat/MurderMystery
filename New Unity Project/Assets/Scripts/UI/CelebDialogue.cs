using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CelebDialogue : MonoBehaviour
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
        dialogueList.Add("I will admit, I was in his room.  But I didn't do anything!");
        dialogueList.Add("I loved him more than the world, more than even myself!");
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void Suspects()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        if (PlayerPrefs.GetInt("CelebSuspects") == 1)
        {
            dialogueList.Add("Are you kidding me? Of course I know who did it!  It was Gregory.");
            dialogueList.Add("People always reject the idea that the nerd did it, but but come on!");
            dialogueList.Add("He was probably plotting this in his room for weeks!");
        }
        else if (PlayerPrefs.GetInt("CelebSuspects") == 4)
        {
            dialogueList.Add("Are you kidding me? Of course I know who did it!  It was that old creep Wally or whatever.");
            dialogueList.Add("That man always gives me the heeby-jeebies.  I don't think he liked anyone.");
        }
        else if (PlayerPrefs.GetInt("CelebSuspects") == 3)
        {
            dialogueList.Add("Are you kidding me? Of course I know who did it!  It was the receptionist.");
            dialogueList.Add("She hated how I was the one that Stephen loved, instead of her.");
            dialogueList.Add("If Stephen wouldn't love her, then he wouldn't love anybody!");
        }
        else
        {
            dialogueList.Add("Are you kidding me? Of course I know who did it!  It was the manager.");
            dialogueList.Add("That man never cared about anything other than money.");
            dialogueList.Add("He killed him in order to drum up some publicity for the hotel!");
        }
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void RoomAsk()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        timer = 0;
        timerGoing = true;
        if (PlayerPrefs.GetInt("CanCelebRoom") == 1)
        {
            dialogueList.Add("Uh... yeah?");
        }
        else
        {
            dialogueList.Add("Okay, but you better not be looking for any souvenirs.");
        }
        PlayerPrefs.SetInt("CanCelebRoom", 1);
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