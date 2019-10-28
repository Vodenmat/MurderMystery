﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OldManDoor : MonoBehaviour
{
    public Text yourDoorText;
    public Text buttonWarningText;
    public Text enterButtonText;
    public GameObject enterButton;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("PlayerKnowsCost", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerPrefs.SetInt("EnterRoom#", 3);
        yourDoorText.text = "Wilfred's Room";
        enterButton.GetComponent<Image>().enabled = true;
        enterButtonText.GetComponent<Text>().enabled = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        PlayerPrefs.SetInt("PlayerKnowsCost", 0);
        yourDoorText.text = "";
        buttonWarningText.text = "";
        enterButton.GetComponent<Image>().enabled = false;
        enterButtonText.GetComponent<Text>().enabled = false;
    }
}