﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotRickRoll : MonoBehaviour
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
        if (collision.gameObject.name == "New Sprite")
        {
            if (this.gameObject.name == "DoctorWho")
            {
                System.Diagnostics.Process.Start("https://www.google.com/doodles/doctor-whos-50th-anniversary");
            }
            else
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }
        }
    }
}
