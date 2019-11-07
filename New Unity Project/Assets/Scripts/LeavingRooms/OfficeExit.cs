using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OfficeExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("CurrentRoom", SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Lobby");
    }

}
