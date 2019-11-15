using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPAnimatorVariables : MonoBehaviour
{
    Animator animator;
    int which = 0;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
         
        if (PlayerPrefs.GetInt("State") == 1)
        {
            GetComponent<Animator>().SetBool("Human", true);
            gameObject.layer = 0;
            which = 0;
            timer = 0;
            if (PlayerPrefs.GetInt("CanShoot") == 1)
            {
                PlayerPrefs.SetInt("CanShoot", 2);
            }
        }
        else if (PlayerPrefs.GetInt("State") == 2)
        {
            GetComponent<Animator>().SetBool("Human", false);
            which = 1;
            timer = 0;
            gameObject.layer = 8;
            if (PlayerPrefs.GetInt("CanShoot") == 2)
            {
                PlayerPrefs.SetInt("CanShoot", 1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        animator = gameObject.GetComponent<Animator>();
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        GetComponent<Animator>().SetFloat("x", x);
        GetComponent<Animator>().SetFloat("y", y);
        if (Input.GetKeyUp("space") && which == 0 && timer > 1 && PlayerPrefs.GetInt("CanChange") == 1)
        {
            GetComponent<Animator>().SetBool("Human", false);
            which = 1;
            timer = 0;
            gameObject.layer = 8;
            PlayerPrefs.SetInt("State", 2);
            if (PlayerPrefs.GetInt("CanShoot") == 2)
            {
                PlayerPrefs.SetInt("CanShoot", 1);
            }
        }
        if (Input.GetKeyUp("space") && which == 1 && timer > 1 && PlayerPrefs.GetInt("CanChange") == 1)
        {
            GetComponent<Animator>().SetBool("Human", true);
            gameObject.layer = 0;
            which = 0;
            timer = 0;
            PlayerPrefs.SetInt("State", 1);
            if (PlayerPrefs.GetInt("CanShoot") == 1)
            {
                PlayerPrefs.SetInt("CanShoot", 2);
            }
        }
    }
}
