using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearingWall : MonoBehaviour
{
    public Transform wall;
    public Transform portal;
    public Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            wall.GetComponent<SpriteRenderer>().enabled = true;
            wall.GetComponent<BoxCollider2D>().enabled = true;
            portal.GetComponent<EnemyPortal>().enabled = true;
            canvas.GetComponent<Canvas>().enabled = true;
            Destroy(gameObject);
        }
    }
}
