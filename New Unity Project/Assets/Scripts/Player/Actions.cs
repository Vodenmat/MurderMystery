using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Actions : MonoBehaviour
{
    public int actions = 10;
    public Text actionText;

    // Start is called before the first frame update
    void Start()
    {
        actionText.text = "Actions: " + (PlayerPrefs.GetInt("Actions")-1);
    }

    // Update is called once per frame
    void Update()
    {
        actionText.text = "Actions: " + (PlayerPrefs.GetInt("Actions")-1);
    }
}
