using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BlackOut : MonoBehaviour
{
    public Color blackColor;
    public GameObject stephen;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("Actions"));
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
            if (blackColor.a > .99 && PlayerPrefs.GetInt("Alive?") == 2)
            {
               // PlayerPrefs.SetInt("CanMove?", 1);
                SceneManager.LoadScene("YourRoom");
            }
            else if (blackColor.a > .99 && PlayerPrefs.GetInt("Alive?") == 1 && stephen.GetComponent<SpriteRenderer>().enabled == true)
            {
                SceneManager.LoadScene("Accusation");
            }
        }
        else
        {
            timer += Time.deltaTime;
            blackColor.a = blackColor.a - Time.deltaTime / 3;
            if (blackColor.a < .5f)
            {
                blackColor.a = .5f;
            }
            if (timer > 18)
            {
                PlayerPrefs.SetInt("Alive?", 1);
                PlayerPrefs.SetInt("Actions", 1);
                PlayerPrefs.SetInt("CanMove?", 1);
                SceneManager.LoadScene("YourRoom");
            }
            if (timer > 16)
            {
                blackColor.a = 255;
            }
            GetComponent<SpriteRenderer>().color = blackColor;
        }
    }
}
