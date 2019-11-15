using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggs4All : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "New Sprite (2)")
        {
            if (this.gameObject.name == "Nyoom")
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Gbn7F0wXqQc");
            }
            else
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QeMhe7At-ho");
            }
        }
    }
}
