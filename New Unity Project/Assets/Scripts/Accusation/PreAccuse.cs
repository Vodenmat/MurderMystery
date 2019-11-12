using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PreAccuse : MonoBehaviour
{
    public Text managerText;
    public Text celebText;
    public Text recepText;
    public Text oldManText;
    public Text nerdText;
    public GameObject square;
    public Button accuseButton;
    public Text accuseButtonText;
    List<string> suspectList = new List<string>();
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
            if (suspectList.Contains("Manager"))
            {
                suspectList.Remove("Manager");
                GameObject squareClone = Instantiate(square, new Vector3(5.66f, 1.91f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                if (suspectList.Count == 0)
                {
                    accuseButton.GetComponent<Image>().enabled = false;
                    accuseButtonText.text = "";
                }
            }
            else
            {
                suspectList.Add("Manager");
                GameObject squareClone = Instantiate(square, new Vector3(5.66f, 1.91f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                accuseButton.GetComponent<Image>().enabled = true;
                accuseButtonText.text = "Accuse?";
            }
        }
        if (this.gameObject.name == "Receptionist" && recepText.text == "Receptionist")
        {
            if (suspectList.Contains("Receptionist"))
            {
                suspectList.Remove("Receptionist");
                GameObject squareClone = Instantiate(square, new Vector3(2.73f, -1.85f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                if (suspectList.Count == 0)
                {
                    accuseButton.GetComponent<Image>().enabled = false;
                    accuseButtonText.text = "";
                }
            }
            else
            {
                suspectList.Add("Receptionist");
                GameObject squareClone = Instantiate(square, new Vector3(2.73f, -1.85f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                accuseButton.GetComponent<Image>().enabled = true;
                accuseButtonText.text = "Accuse?";
            }
        }
        if (this.gameObject.name == "OldMan" && oldManText.text == "Old Man")
        {
            if (suspectList.Contains("OldMan"))
            {
                suspectList.Remove("OldMan");
                GameObject squareClone = Instantiate(square, new Vector3(0, 1.91f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                if (suspectList.Count == 0)
                {
                    accuseButton.GetComponent<Image>().enabled = false;
                    accuseButtonText.text = "";
                }
            }
            else
            {
                suspectList.Add("OldMan");
                GameObject squareClone = Instantiate(square, new Vector3(0, 1.91f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                accuseButton.GetComponent<Image>().enabled = true;
                accuseButtonText.text = "Accuse?";
            }
        }
        if (this.gameObject.name == "Celebrity" && celebText.text == "Celebrity")
        {
            if (suspectList.Contains("Celebrity"))
            {
                suspectList.Remove("Celebrity");
                GameObject squareClone = Instantiate(square, new Vector3(-2.83f, -1.85f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                if (suspectList.Count == 0)
                {
                    accuseButton.GetComponent<Image>().enabled = false;
                    accuseButtonText.text = "";
                }
            }
            else
            {
                suspectList.Add("Celebrity");
                GameObject squareClone = Instantiate(square, new Vector3(-2.83f, -1.85f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                accuseButton.GetComponent<Image>().enabled = true;
                accuseButtonText.text = "Accuse?";
            }
        }
        if (this.gameObject.name == "Nerd" && nerdText.text == "Nerd")
        {
            if (suspectList.Contains("Nerd"))
            {
                suspectList.Remove("Nerd");
                GameObject squareClone = Instantiate(square, new Vector3(-5.56f, 1.91f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                if (suspectList.Count == 0)
                {
                    accuseButton.GetComponent<Image>().enabled = false;
                    accuseButtonText.text = "";
                }
            }
            else
            {
                suspectList.Add("Nerd");
                GameObject squareClone = Instantiate(square, new Vector3(-5.56f, 1.91f, 0), Quaternion.identity);
                squareClone.GetComponent<SpriteRenderer>().enabled = true;
                accuseButton.GetComponent<Image>().enabled = true;

            }
        }
    }
}

