﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
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
