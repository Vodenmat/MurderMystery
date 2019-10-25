using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class YourDoor : MonoBehaviour
{
    public Text yourDoorText;
    public Text Dialogue;
    public GameObject enterButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        yourDoorText.text = "Your Room";

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        yourDoorText.text = "";
    }
}
