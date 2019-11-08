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
    public GameObject square;
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
    void OnMouseDown()
    {
        if (this.gameObject.name == "Manager" && managerText.text == "Manager")
        {
            square.GetComponent<SpriteRenderer>().enabled = true;
            PlayerPrefs.SetInt("Suspect", 4);
            square.transform.position = new Vector3(5.66f, 1.91f, 0);
        }
        if (this.gameObject.name == "Receptionist" && recepText.text == "Receptionist")
        {
            PlayerPrefs.SetInt("Suspect", 5);
            square.GetComponent<SpriteRenderer>().enabled = true;
            square.transform.position = new Vector3(2.73f, -1.85f, 0);
        }
        if (this.gameObject.name == "OldMan" && oldManText.text == "Old Man")
        {
            PlayerPrefs.SetInt("Suspect", 3);
            square.GetComponent<SpriteRenderer>().enabled = true;
            square.transform.position = new Vector3(0, 1.91f, 0);
        }
        if (this.gameObject.name == "Celebrity" && celebText.text == "Celebrity")
        {
            PlayerPrefs.SetInt("Suspect", 2);
            square.GetComponent<SpriteRenderer>().enabled = true;
            square.transform.position = new Vector3(-2.83f, -1.85f, 0);
        }
        if (this.gameObject.name == "Nerd" && nerdText.text == "Nerd")
        {
            PlayerPrefs.SetInt("Suspect", 1);
            square.GetComponent<SpriteRenderer>().enabled = true;
            square.transform.position = new Vector3(-5.56f, 1.91f, 0);
        }
    }
}
