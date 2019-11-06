using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BlackOut : MonoBehaviour
{
    public Color blackColor;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Actions") == 1)
        {
            blackColor.a = 0;
        }
        else
        {
            blackColor.a = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Actions") == 1)
        {
            blackColor.a = blackColor.a + Time.deltaTime / 3;
            GetComponent<SpriteRenderer>().color = blackColor;
            if (blackColor.a > .99)
            {
                PlayerPrefs.SetInt("Actions", 5);
                SceneManager.LoadScene("YourRoom");
            }
        }
        else
        {
            blackColor.a = blackColor.a - Time.deltaTime / 3;
            GetComponent<SpriteRenderer>().color = blackColor;
        }
    }
}
