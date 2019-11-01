using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTopDownMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Lobby" && PlayerPrefs.GetInt("StairsTouched") == 1)
        {
            transform.position = new Vector3(0, 23.92f, 0);
        }
        else if (SceneManager.GetActiveScene().name == "Lobby")
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (PlayerPrefs.GetInt("Actions") == 0)
        {
            PlayerPrefs.SetInt("Actions", 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 oldPosition;
        if (PlayerPrefs.GetInt("CanMove?") == 1)
        {
            oldPosition = (transform.position);
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = transform.position.z;
            transform.up = mousePosition - transform.position;
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            Vector2 moveDir = y * transform.up + x * transform.right;
            moveDir.Normalize();
            GetComponent<Rigidbody2D>().velocity = moveDir * moveSpeed;
        }
        else
        {
            //transform.position = new Vector3(oldPosition.x, oldPosition.y, oldPosition.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            transform.up = new Vector3(0, 0, 0);
        }
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
        if (collision.gameObject.name == "Manager")
        {
            PlayerPrefs.SetString("SpeakingTo", "Manager");
        }
        else if (collision.gameObject.name == "Receptionist")
        {
            PlayerPrefs.SetString("SpeakingTo", "Receptionist");
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HallDoor")
        {
            SceneManager.LoadScene("Hallway");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
