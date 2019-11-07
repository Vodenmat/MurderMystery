using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerAnim : MonoBehaviour
{
    float timer = 0;
    int frames = 0;
    public RuntimeAnimatorController killer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Alive?") == 1)
        {
            timer += Time.deltaTime;
            if (timer > 5)
            {
                GetComponent<SpriteRenderer>().enabled = true;
                timer = 0;
            }
            else if (GetComponent<SpriteRenderer>().enabled == true && transform.position.y == 2.06f)
            {
                if (timer > 3)
                {
                    transform.position = transform.position - new Vector3(0, .05f, 0);
                }
            }
            else if (GetComponent<SpriteRenderer>().enabled == true && timer > .05f && transform.position.y > -1.25f)
            {
                transform.position = transform.position - new Vector3(0, .05f, 0);
                timer = 0;
            }
            else if (GetComponent<SpriteRenderer>().enabled == true && timer > .05f && frames < 55)
            {
                transform.up = transform.up - new Vector3(-.022f, 0, 0);
                timer = 0;
                frames++;
                Debug.Log(frames);
            }
            else if (GetComponent<SpriteRenderer>().enabled == true && frames == 55)
            {
                GetComponent<Animator>().runtimeAnimatorController = killer;
            }
        }
    }
}
