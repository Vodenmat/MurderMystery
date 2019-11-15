using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyPortal : MonoBehaviour
{
    public GameObject enemy;
    public GameObject winWall;
    float timer = 0;
    float roundedTimer = 1;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (roundedTimer < timer && roundedTimer < 31)
        {
            timerText.text = roundedTimer.ToString();
            roundedTimer++;
        }
        if (roundedTimer == 31)
        {
            Destroy(enemy);
            Destroy(winWall);
            timer = -999999999;
            timerText.text = "";
        }
    }
}
