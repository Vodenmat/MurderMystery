using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ActionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "YourRoom" && PlayerPrefs.GetInt("Actions") == 1)
        {
            GetComponent<Text>().enabled = false;
        }
    }
}
