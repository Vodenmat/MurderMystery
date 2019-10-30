using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurderCalculator : MonoBehaviour
{
    System.Random rnd;
    int rndBackup;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Calculated") == 0)
        {
            PlayerPrefs.SetInt("Murderer", rnd.Next(1, 6));
            /*
             * 1 = Nerd
             * 2 = Celeb
             * 3 = Old man
             * 4 = Manager
             * 5 = Receptionist
            */
            PlayerPrefs.SetInt("WhoKnows", rnd.Next(1, 6));
            if (PlayerPrefs.GetInt("WhoKnows") == 1)
            {
                PlayerPrefs.SetInt("NerdSuspects", PlayerPrefs.GetInt("Murderer"));
            }
            else
            {
                rndBackup = PlayerPrefs.GetInt("Murderer");
                while (rndBackup == PlayerPrefs.GetInt("Murderer"))
                {
                    rndBackup = rnd.Next(1, 6);
                }
                PlayerPrefs.SetInt("NerdSuspects", rndBackup);
            }
        }
    }
}
