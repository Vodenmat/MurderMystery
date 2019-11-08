using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AccusationChoice : MonoBehaviour
{
    public Text managerText;
    public Text celebText;
    public Text recepText;
    public Text oldManText;
    public Text nerdText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        if (this.gameObject.name == "Manager" && Input.GetMouseButtonDown(1))
        {
            PlayerPrefs.SetInt("Suspect", 4);
            GetComponent<SpriteRenderer>().color = Color.gray;
        }
        else if (this.gameObject.name == "Manager")
        {
            managerText.text = "Manager";
        }
        else
        {
            managerText.text = "";
        }
        if (this.gameObject.name == "Celebrity")
        {
            celebText.text = "Celebrity";
        }
        else
        {
            celebText.text = "";
        }
        if (this.gameObject.name == "OldMan")
        {
            oldManText.text = "Old Man";
        }
        else
        {
            oldManText.text = "";
        }
        if (this.gameObject.name == "Nerd")
        {
            nerdText.text = "Nerd";
        }
        else
        {
            nerdText.text = "";
        }
        if (this.gameObject.name == "Receptionist")
        {
            recepText.text = "Receptionist";
        }
        else
        {
            recepText.text = "";
        }
    }
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.name == "Manager")
        {
            managerText.text = "Manager";
        }
        else if (this.gameObject.name == "Receptionist")
        {
            recepText.text = "Receptionist";
        }
        else if (this.gameObject.name == "Nerd")
        {
            nerdText.text = "Nerd";
        }
        else if (this.gameObject.name == "Celebrity")
        {
            celebText.text = "Celebrity";
        }
        else if (this.gameObject.name == "OldMan")
        {
            oldManText.text = "Old Man";
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (this.gameObject.name == "Manager")
        {
            managerText.text = "";
        }
        else if (this.gameObject.name == "Receptionist")
        {
            recepText.text = "";
        }
        else if (this.gameObject.name == "Nerd")
        {
            nerdText.text = "";
        }
        else if (this.gameObject.name == "Celebrity")
        {
            celebText.text = "";
        }
        else if (this.gameObject.name == "OldMan")
        {
            oldManText.text = "";
        }
    }*/
    void OnMouseDown()
    {
        if (this.gameObject.name == "Manager" && managerText.text == "Manager")
        {
            PlayerPrefs.SetInt("Suspect", 4);
            GetComponent<SpriteRenderer>().color = Color.gray;
        }
    }
}
