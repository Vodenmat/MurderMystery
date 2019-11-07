using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerTopDownMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameObject prefab;
    public Canvas canvas;
    public Text dialogue;
    // Start is called before the first frame update
    void Start()
    {
      //  if (SceneManager.GetActiveScene().name == "YourRoom" && )
        if (SceneManager.GetActiveScene().name == "Hallway" && PlayerPrefs.GetString("CurrentRoom") == "NerdRoom")
        {
            transform.position = new Vector3(-1, 11, 0);
        }
        if (SceneManager.GetActiveScene().name == "Hallway" && PlayerPrefs.GetString("CurrentRoom") == "YourRoom")
        {
            transform.position = new Vector3(-1, 33, 0);
        }
        if (SceneManager.GetActiveScene().name == "Hallway" && PlayerPrefs.GetString("CurrentRoom") == "OldManRoom")
        {
            transform.position = new Vector3(1, 22, 0);
        }
        if (SceneManager.GetActiveScene().name == "Hallway" && PlayerPrefs.GetString("CurrentRoom") == "CelebRoom")
        {
            transform.position = new Vector3(1, 11, 0);
        }
        if (SceneManager.GetActiveScene().name == "Hallway" && PlayerPrefs.GetString("CurrentRoom") == "StephenRoom")
        {
            transform.position = new Vector3(-1, 22, 0);
        }
        if (SceneManager.GetActiveScene().name == "Hallway" && PlayerPrefs.GetString("CurrentRoom") == "Hallway")
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (SceneManager.GetActiveScene().name == "Lobby" && PlayerPrefs.GetInt("StairsTouched") == 1)
        {
            transform.position = new Vector3(0, 23.92f, 0);
        }
        else if (SceneManager.GetActiveScene().name == "Lobby")
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (SceneManager.GetActiveScene().name == "Lobby" && PlayerPrefs.GetString("CurrentRoom") == "Office")
        {
            transform.position = new Vector3(-5, 11, 0);
        }

        if (PlayerPrefs.GetInt("Actions") == 0)
        {
            PlayerPrefs.SetInt("Actions", 5);
        }
        if (PlayerPrefs.GetInt("Actions") == 1 && PlayerPrefs.GetInt("Alive?") == 2)
        {
            PlayerPrefs.SetInt("CanMove?", 0);
            canvas.GetComponent<Canvas>().enabled = true;
            dialogue.text = "Well, it's gotten late.";
            GameObject fade = Instantiate(prefab, transform.position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Alive?") == 0)
        {
            PlayerPrefs.SetInt("Alive?", 2); //2 = alive, 1 = dead
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
            PlayerPrefs.SetString("CurrentRoom", "Hallway");
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
        if (collision.gameObject.name == "ManagerAura")
        {
            PlayerPrefs.SetString("SpeakingTo", "Manager");
        }
        else if (collision.gameObject.name == "ReceptionistAura")
        {
            PlayerPrefs.SetString("SpeakingTo", "Receptionist");
        }
        else if (collision.gameObject.name == "CelebrityAura")
        {
            PlayerPrefs.SetString("SpeakingTo", "Celebrity");
        }
        else if (collision.gameObject.name == "NerdAura")
        {
            PlayerPrefs.SetString("SpeakingTo", "Nerd");
        }
        else if (collision.gameObject.name == "OldManAura")
        {
            PlayerPrefs.SetString("SpeakingTo", "OldMan");
        }
    }
}
