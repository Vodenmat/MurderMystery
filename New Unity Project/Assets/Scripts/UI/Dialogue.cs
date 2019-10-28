using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue : MonoBehaviour
{
    public Text dialogueText;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        OpeningText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OpeningText()
    {
        dialogueText.text = "Thank you so much for coming detective!";
        timer += Time.deltaTime;
        if (timer > 5)
        {
            dialogueText.text = "The hotel hasn't been the same since the murder.";
        }
        if (this.name == "Manager")
        {

        }
    }
}
