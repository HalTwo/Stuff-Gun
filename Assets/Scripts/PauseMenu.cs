using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseUi;

    private bool paused = false;
    void Start()
    {
      //  pauseUi.SetActive(false);
    }
    void Update()

    {
         if (Input.GetButtonDown("Pause"))
            {
                paused = !paused;
            }
            if (paused)
            {
                pauseUi.SetActive(true);
                Time.timeScale = 0;
            }
        /*  if (!paused)
          {
              pauseUi.SetActive(false);
              Time.timeScale = 1;
          }

  }

  public void resume()
  {
      paused = false;
  }
  public void restart()
  {
      Application.LoadLevel(Application.loadedLevel);
  }
  public void mainmenu()    
  {
      Application.LoadLevel(0);
  }
  public void quitgame()
  {
      Application.Quit(); */
    }
}
