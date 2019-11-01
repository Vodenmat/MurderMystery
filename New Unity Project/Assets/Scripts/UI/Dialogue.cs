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
    public Canvas recepCanvas;
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
            if (dialogueText.text == "")
            {
                dialogueText.text = "Thank you so much for coming detective.";
            }
            OpeningText();
            timer += Time.deltaTime;
        }
    }

    public void OpeningText()
    {
        PlayerPrefs.SetInt("CanMove?", 0);
        if (this.gameObject.name == "ManagerAura" && Input.GetMouseButtonDown(0))
        {
            if (dialogueText.text == "Thank you so much for coming detective.")
            {
                dialogueText.text = "The hotel hasn't been the same since the murder.";
            }
            else if (dialogueText.text == "The hotel hasn't been the same since the murder.")
            {
                dialogueText.text = "Stephen was such a fine young man too...";
            }
            else if (dialogueText.text == "Stephen was such a fine young man too...")
            {
                dialogueText.text = "";
                PlayerPrefs.SetInt("CanMove?", 1);
                PlayerPrefs.SetInt("Intro?", 1);
            }
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (PlayerPrefs.GetInt("CanMove?") == 1 && (this.gameObject.name == "ManagerAura" || this.gameObject.name == "ReceptionistAura"))
        {
            speakButton.GetComponent<Image>().enabled = true;
            speakButtonText.text = "Talk?";
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (this.gameObject.name == "ManagerAura" || this.gameObject.name == "ReceptionistAura")
        {
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
        }
    }
    public void Speaking()
    {
        if (PlayerPrefs.GetString("SpeakingTo") == "Manager")
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
            managerCanvas.GetComponent<Canvas>().enabled = true;
        }
        else if (PlayerPrefs.GetString("SpeakingTo") == "Receptionist")
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
            recepCanvas.GetComponent<Canvas>().enabled = true;
        }
    }
}
