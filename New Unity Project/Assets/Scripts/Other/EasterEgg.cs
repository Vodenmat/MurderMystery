using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EasterEgg : MonoBehaviour
{
    int easter = 0;
    int easter2 = 0;
    int supereaster = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            if (Input.GetKeyDown("z") && easter == 0)
            {
                easter++;
            }
            if (Input.GetKeyDown("e") && easter == 1)
            {
                easter++;
            }
            if (Input.GetKeyDown("r") && easter == 2)
            {
                easter++;
            }
            if (Input.GetKeyDown("o") && easter == 3)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Ze3G5EksIQw");
            }
            if (Input.GetKeyDown("m") && easter2 == 0)
            {
                easter2++;
            }
            if (Input.GetKeyDown("r") && easter2 == 1)
            {
                easter2++;
            }
            if (Input.GetKeyDown("a") && easter2 == 2)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=m9tdKwdxnj0");
            }
            if (Input.GetKeyDown("p") && supereaster == 0)
            {
                supereaster++;
            }
            if (Input.GetKeyDown("a") && supereaster == 1)
            {
                supereaster++;
            }
            if (Input.GetKeyDown("p") && supereaster == 2)
            {
                supereaster++;
            }
            if (Input.GetKeyDown("e") && supereaster == 3)
            {
                supereaster++;
            }
            if (Input.GetKeyDown("r") && supereaster == 4)
            {
                SceneManager.LoadScene("PMainMenu");
            }

        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "New Sprite" && this.gameObject.name == "EasterEgg")
        {
            System.Diagnostics.Process.Start("https://www.google.com/doodles/30th-anniversary-of-pac-man");
        }
        else if (this.gameObject.name == "DoctorWho")
        {
            System.Diagnostics.Process.Start("https://www.google.com/doodles/doctor-whos-50th-anniversary");
        }
        else
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
