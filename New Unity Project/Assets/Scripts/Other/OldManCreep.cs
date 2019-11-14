using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManCreep : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.name == "OldMan" && PlayerPrefs.GetInt("OldManEntered") == 1 && PlayerPrefs.GetInt("Alive?") == 2)
        {
            transform.position = new Vector3(-6.8f, 2.28f, -3);
        }
        else if (this.gameObject.name == "OldMan")
        {
            transform.position = new Vector3(-4.96f, 3.39f, -3);
        }
        PlayerPrefs.SetInt("OldManEntered", 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = transform.position - player.transform.position;
    }
}
