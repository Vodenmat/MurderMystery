using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
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
        if (collision.gameObject.tag == "Player")
        {
            for (float i = 0; i < 50;)
            {
                transform.localScale = new Vector3(transform.localScale.x + .1f, transform.localScale.y + .1f, 0);
                i += Time.deltaTime / 100;
            }
            SceneManager.LoadScene("Dungeon");
        }        
    }
}
