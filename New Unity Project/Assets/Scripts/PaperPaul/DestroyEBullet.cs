using UnityEngine;
using System.Collections;

public class DestroyEBullet : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Enemy" && collision.gameObject.tag != "Rocks")
        {
            Destroy(gameObject);
        }
    }

}
