using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public Transform MainMenu;
    public Transform HUD;
    public Transform Pause;
    public Transform Credits;
    public Transform GameOver;
        
    void Update()
    {
        

        if (Input.GetButtonDown("Pause"))
        {
            if (HUD.gameObject.activeInHierarchy == true && GameOver.gameObject.activeInHierarchy == false)
            {
                Paused();
            }
        }
    }


    public void ExitGame()
    {
        Application.Quit();
    }
    public void TimeStop()
    {
        Time.timeScale = 0;
    }

    public void TimeStart()
    {
        Time.timeScale = 1;
    }
    public void Paused()
    {
        if (Pause.gameObject.activeInHierarchy == false)
        {
            Pause.gameObject.SetActive(true);
            TimeStop();
        }
        else
        {
            Pause.gameObject.SetActive(false);
            TimeStart();
        }
    }
}
