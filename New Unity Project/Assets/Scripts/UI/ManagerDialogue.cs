using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerDialogue : MonoBehaviour
{
    public GameObject dialogueCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
