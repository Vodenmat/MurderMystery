using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StephenDialogue : MonoBehaviour
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
    public void WhoKilled()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        dialogueList.Add("I don't know...");
        dialogueList.Add("Tell me who you think and maybe that'll jog my memory");
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
            SceneManager.LoadScene("PreAccuse");
        }
        else
        {
            timer = 0;
            dialogueList.RemoveAt(0);
        }
        dialogue.text = dialogueList[0];
    }
}