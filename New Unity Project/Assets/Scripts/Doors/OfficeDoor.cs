using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OfficeDoor : MonoBehaviour
{
    public Text yourDoorText;
    public Text buttonWarningText;
    public Text enterButtonText;
    public GameObject enterButton;
    public Button talkButton;
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
        PlayerPrefs.SetInt("EnterRoom#", 7);
        yourDoorText.text = "Manager's Office";
        enterButton.GetComponent<Image>().enabled = true;
        enterButtonText.GetComponent<Text>().enabled = true;
        talkButton.GetComponent<Button>().interactable = false;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        PlayerPrefs.SetInt("PlayerKnowsCost", 0);
        yourDoorText.text = "";
        buttonWarningText.text = "";
        enterButton.GetComponent<Image>().enabled = false;
        enterButtonText.GetComponent<Text>().enabled = false;
        talkButton.GetComponent<Button>().interactable = true;
    }
}