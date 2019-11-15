using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOREGG : MonoBehaviour
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
        if (collision.gameObject.name == "New Sprite (2)")
        {
            if (this.gameObject.name == "Default")
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=8pU7d_XzQa4");
            }
            else
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=_DaR1J0Cl8I");
            }
        }
    }
}
