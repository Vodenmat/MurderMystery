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
    public Canvas celebCanvas;
    public Canvas nerdCanvas;
    public Canvas oldManCanvas;
    public Canvas stephenCanvas;
    public GameObject stephen;
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
        if (PlayerPrefs.GetInt("CanMove?") == 1 && PlayerPrefs.GetInt("Alive?") == 2 && PlayerPrefs.GetInt("Actions") != 1 && (this.gameObject.name == "ManagerAura" || this.gameObject.name == "ReceptionistAura" || this.gameObject.name == "CelebrityAura" || this.gameObject.name == "NerdAura" || this.gameObject.name == "OldManAura" || (this.gameObject.name == "StephenAura" && stephen.GetComponent<SpriteRenderer>().enabled == true)))
        {
            speakButton.GetComponent<Image>().enabled = true;
            speakButtonText.text = "Talk?";
        }
        if (PlayerPrefs.GetInt("CanMove?") == 1 && this.gameObject.name == "StephenAura" && stephen.GetComponent<SpriteRenderer>().enabled == true)
        {
            speakButton.GetComponent<Image>().enabled = true;
            speakButtonText.text = "Talk?";
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (this.gameObject.name == "ManagerAura" || this.gameObject.name == "ReceptionistAura" || this.gameObject.name == "CelebrityAura" || this.gameObject.name == "NerdAura" || this.gameObject.name == "OldManAura" || (this.gameObject.name == "StephenAura" && stephen.GetComponent<SpriteRenderer>().enabled == true))
        {
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
        }
        if (PlayerPrefs.GetInt("CanMove?") == 1 && this.gameObject.name == "StephenAura" && stephen.GetComponent<SpriteRenderer>().enabled == true)
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
        else if (PlayerPrefs.GetString("SpeakingTo") == "Celebrity")
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
            celebCanvas.GetComponent<Canvas>().enabled = true;
        }
        else if (PlayerPrefs.GetString("SpeakingTo") == "Nerd")
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
            nerdCanvas.GetComponent<Canvas>().enabled = true;
        }
        else if (PlayerPrefs.GetString("SpeakingTo") == "OldMan")
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
            oldManCanvas.GetComponent<Canvas>().enabled = true;
        }
        else if (PlayerPrefs.GetString("SpeakingTo") == "Stephen")
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            speakButton.GetComponent<Image>().enabled = false;
            speakButtonText.text = "";
            stephenCanvas.GetComponent<Canvas>().enabled = true;
        }
    }
}
