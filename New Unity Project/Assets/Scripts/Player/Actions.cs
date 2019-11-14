using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActionCounter : MonoBehaviour
{
    public int health = 10;
    public Text actionText;
    public Slider actionSlider;
    //public int lives;
    // Start is called before the first frame update
    void Start()
    {
        actionText.text = "HP: " + health;
        actionSlider.maxValue = health;
        actionSlider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
