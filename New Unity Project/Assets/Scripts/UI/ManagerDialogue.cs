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
    void Update()
    {
        if (timerGoing == true)
        {
            timer += Time.deltaTime;
            if (timer > 3)
            {
                PlayerPrefs.SetInt("CanMove?", 1);
                timerGoing = false;
                timer = 0;
                dialogue.text = "";
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
    }
    public void OfficeAsk()
    {
        GetComponent<Canvas>().enabled = false;
        dialogueCanvas.GetComponent<Canvas>().enabled = true;
        PlayerPrefs.SetInt("CanOffice", 1);
        timerGoing = true;
        dialogue.text = "Oh, of course.";
    }
}
