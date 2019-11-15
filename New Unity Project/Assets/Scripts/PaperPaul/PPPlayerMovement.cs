using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PPPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int lives;
    public int health = 10;
    Vector3 position = new Vector3();
    public Text healthText;
    public Canvas notifText;
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();
        if (PlayerPrefs.GetInt("Lives") != 0)
        {
            lives = PlayerPrefs.GetInt("Lives");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey("space"))
        {
            notifText.GetComponent<Canvas>().enabled = false;
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = velocity * moveSpeed;
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (collision.gameObject.tag == "MagicOrb")
        {
            notifText.GetComponent<Canvas>().enabled = true;
            PlayerPrefs.SetInt("CanChange", 1);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Hole")
        {
            SceneManager.LoadScene("Dungeon");
        }
        if (collision.gameObject.tag == "Ladder")
        {
            SceneManager.LoadScene("Overworld");
        }
        if (collision.gameObject.tag == "Pistol")
        {
            if (GetComponent<Animator>().GetBool("Human") == true)
            {
                PlayerPrefs.SetInt("CanShoot", 2);
            }
            else
            {
                PlayerPrefs.SetInt("CanShoot", 1);
            }
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "EBullet")
        {
            health--;
            healthText.text = health.ToString();
            if (health == 0)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        if (collision.gameObject.tag == "Trophy")
        {
            SceneManager.LoadScene("Win");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EBullet")
        {
            health--;
            healthText.text = health.ToString();
            if (health == 0)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }    
    }
}
