using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeetsterEgg : MonoBehaviour
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
            if (this.gameObject.name == "Alia")
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=CHD8cWEVVcY");
            }
            else
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=wDgQdr8ZkTw");
            }
        }
    }
}
