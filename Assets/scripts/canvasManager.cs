using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasManager : MonoBehaviour
{
    private bool isPaused = false;
    private void Start()
    {
        menuManager.Init();
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Time.timeScale = 0;
                menuManager.settingsMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                menuManager.settingsMenu.SetActive(true);
            }
        }
    }
}
