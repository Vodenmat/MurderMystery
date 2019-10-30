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
                while (rndBackup == PlayerPrefs.GetInt("Murderer") || rndBackup == 1)
                {
                    rndBackup = rnd.Next(1, 6);
                }
                PlayerPrefs.SetInt("NerdSuspects", rndBackup);
            }
            if (PlayerPrefs.GetInt("WhoKnows") == 2)
            {
                PlayerPrefs.SetInt("CelebSuspects", PlayerPrefs.GetInt("Murderer"));
            }
            else
            {
                rndBackup = PlayerPrefs.GetInt("Murderer");
                while (rndBackup == PlayerPrefs.GetInt("Murderer") || rndBackup == 2)
                {
                    rndBackup = rnd.Next(1, 6);
                }
                PlayerPrefs.SetInt("CelebSuspects", rndBackup);
            }
            if (PlayerPrefs.GetInt("WhoKnows") == 3)
            {
                PlayerPrefs.SetInt("OldManSuspects", PlayerPrefs.GetInt("Murderer"));
            }
            else
            {
                rndBackup = PlayerPrefs.GetInt("Murderer");
                while (rndBackup == PlayerPrefs.GetInt("Murderer") || rndBackup == 3)
                {
                    rndBackup = rnd.Next(1, 6);
                }
                PlayerPrefs.SetInt("OldManSuspects", rndBackup);
            }
            if (PlayerPrefs.GetInt("WhoKnows") == 4)
            {
                PlayerPrefs.SetInt("ManagerSuspects", PlayerPrefs.GetInt("Murderer"));
            }
            else
            {
                rndBackup = PlayerPrefs.GetInt("Murderer");
                while (rndBackup == PlayerPrefs.GetInt("Murderer") || rndBackup == 4)
                {
                    rndBackup = rnd.Next(1, 6);
                }
                PlayerPrefs.SetInt("ManagerSuspects", rndBackup);
            }
            if (PlayerPrefs.GetInt("WhoKnows") == 5)
            {
                PlayerPrefs.SetInt("ReceptionistSuspects", PlayerPrefs.GetInt("Murderer"));
            }
            else
            {
                rndBackup = PlayerPrefs.GetInt("Murderer");
                while (rndBackup == PlayerPrefs.GetInt("Murderer") || rndBackup == 5)
                {
                    rndBackup = rnd.Next(1, 6);
                }
                PlayerPrefs.SetInt("ReceptionistSuspects", rndBackup);
            }
            PlayerPrefs.SetInt("Calculated", 1);
        }        
    }
}
