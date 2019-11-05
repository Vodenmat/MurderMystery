using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LOL : MonoBehaviour
{
    void Start()
    {

        PlayerPrefs.SetString("CurrentRoom", SceneManager.GetActiveScene().name);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Hallway");      
    }
}
