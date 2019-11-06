using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NerdDialogue : MonoBehaviour
{
    public GameObject dialogueCanvas;
    public GameObject prefab;
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
        if (PlayerPrefs.GetInt("Actions") == 1 && timerGoing == false)
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            dialogueCanvas.GetComponent<Canvas>().enabled = true;
            dialogue.text = "Well, it's gotten late.";
            GameObject fade = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
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
        dialogueList.Add("In my room, obviously.");
        dialogue.text = dialogueList[0];
        timer = 0;
        timerGoing = true;
    }
    public void Suspects() //Takes an action
    {
        PlayerPrefs.SetInt("Actions", PlayerPrefs.GetInt("Actions") - 1);
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        dialogueList.Add("Well, uh... not really.");
        if (PlayerPrefs.GetInt("NerdSuspects") == 2)
        {
            dialogueList.Add("I don't see the others much, but Tracy frightens me.");
        }
        else if (PlayerPrefs.GetInt("NerdSuspects") == 4)
        {
            dialogueList.Add("I don't see the others much, but the manager frightens me.");
        }
        else if (PlayerPrefs.GetInt("NerdSuspects") == 3)
        {
            dialogueList.Add("I don't see the others much, but that old guy frightens me.");
        }
        else
        {
            dialogueList.Add("I don't see the others much, but the receptionist frightens me.");
        }
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
        dialogueList.Add("Whoa, there was a murder!?");
        dialogueList.Add("This is just like 'Trek Wars: Annihilation'!");
        dialogueList.Add("Just with a hotel, humans, and actual murder!");
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