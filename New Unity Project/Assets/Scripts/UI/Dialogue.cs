using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue : MonoBehaviour
{
    public Text dialogueText;
    public GameObject speakButton;
    public Text speakButtonText;
    public Canvas managerCanvas;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Intro?") == 0)
        {
            OpeningText();
            timer += Time.deltaTime;
        }
    }

    public void OpeningText()
    {
        PlayerPrefs.SetInt("CanMove?", 0);
        if (this.gameObject.name == "Manager" && timer > 9)
        {
            dialogueText.text = "";
            PlayerPrefs.SetInt("CanMove?", 1);
            PlayerPrefs.SetInt("Intro?", 1);
        }
        else if (this.gameObject.name == "Manager" && timer > 6)
        {
            dialogueText.text = "Stephen was such a fine young man too...";
        }
        else if (this.gameObject.name == "Manager" && timer > 3)
        {
            dialogueText.text = "The hotel hasn't been the same since the murder.";
        }
        else if (this.gameObject.name == "Manager")
        {
            dialogueText.text = "Thank you so much for coming, detective.";
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.name == "Manager")
        {
            speakButton.GetComponent<Image>().enabled = true;
            speakButtonText.text = "Talk?";
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (this.gameObject.name == "Manager")
        {
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
        }
    }
    public void Speaking()
    {
        if (this.gameObject.name == "Manager")
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
            managerCanvas.GetComponent<Canvas>().enabled = true;
        }
    }
}
