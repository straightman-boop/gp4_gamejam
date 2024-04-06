using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasManager : MonoBehaviour
{
    private bool isPaused = false;
    private bool isInventory = false;
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
                menuManager.settingsMenu.SetActive(false);
            }
        }

        if(Input.GetKeyDown("i"))
        {
            if(!isPaused)
            {
                isInventory= !isInventory;
                if(isInventory)
                {
                    Time.timeScale = 0;
                    menuManager.inventory.SetActive(true);
                }
                else
                {
                    Time.timeScale= 1;
                    menuManager.inventory.SetActive(false);
                }
            }
        }
    }
    public void ResumeGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        menuManager.settingsMenu.SetActive(false);
    }
    public void openContainer()
    {
        menuManager.containers.SetActive(true);
    }
    public void closeContainer()
    {
        menuManager.containers.SetActive(false);
    }
}
