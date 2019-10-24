using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorVariables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        GetComponent<Animator>().SetFloat("x", x);
        GetComponent<Animator>().SetFloat("y", y);
    }
}
