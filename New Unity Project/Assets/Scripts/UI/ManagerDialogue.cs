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
        while (timerGoing == true && dialogueList.Count > 0)
        {
            timer += Time.deltaTime;
            dialogue.text = dialogueList[1];
            if (timer > 3 && dialogueList.Count == 1)
            {
                PlayerPrefs.SetInt("CanMove?", 1);
                timerGoing = false;
                timer = 0;
                dialogue.text = "";
            }
            else if (timer > 3)
            {
                timer = 0;
                dialogueList.RemoveAt(1);
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
        timerGoing = true;
        if (PlayerPrefs.GetInt("ManagerSuspects") == 1)
        {
            dialogueList.Add("Well, I'm not sure if I'm allowed to have an opinion here, but I'd watch out for Gregory");
            dialogueList.Add("He just sits in his room, hating social situations.");
        }
    }
    public void OfficeAsk()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        PlayerPrefs.SetInt("CanOffice", 1);
        timerGoing = true;
        dialogueList.Add("Oh, of course.");
    }
}
