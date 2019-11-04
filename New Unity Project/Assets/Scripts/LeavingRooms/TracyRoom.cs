using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tracyroom : MonoBehaviour
{
    public int scoreCount = 0;

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "plus")
        {
            scoreCount++;
            if (scoreCount >= 1)
            {
                SceneManager.LoadScene("Scene2");

            }
        }
        else if (collision.gameObject.tag == "minus")
        {

        }

    }









}

