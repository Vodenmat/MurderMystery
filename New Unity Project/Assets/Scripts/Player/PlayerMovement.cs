using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Lobby" && PlayerPrefs.GetInt("StairsTouched") == 1)
        {
            transform.position = new Vector3(0, 23.92f, 0);
        }
        else
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = velocity * moveSpeed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Stairs")
        {
            PlayerPrefs.SetInt("StairsTouched", 1);
            if (SceneManager.GetActiveScene().name == "Lobby")
            {
                SceneManager.LoadScene("Hallway");
            }
            else
            {
                SceneManager.LoadScene("Lobby");
            }
        }
        if (collision.gameObject.tag == "NerdDoor")
        {
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("NerdRoom");
            }
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
