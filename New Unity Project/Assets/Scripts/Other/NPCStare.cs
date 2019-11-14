using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCStare : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = transform.position - player.transform.position;
    }
}
