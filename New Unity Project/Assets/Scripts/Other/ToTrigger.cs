using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Alive?") == 1)
        {
            gameObject.layer = 9;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
