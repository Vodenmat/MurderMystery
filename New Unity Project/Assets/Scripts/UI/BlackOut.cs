using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlackOut : MonoBehaviour
{
    public Color blackColor;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Actions") == 0)
        {
            blackColor.a = 0;
            blackColor.a += .01f;
            GetComponent<Image>().color = blackColor;
        }
        else
        {
            blackColor.a = 1;
            blackColor.a -= .01f;
            GetComponent<Image>().color = blackColor;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
