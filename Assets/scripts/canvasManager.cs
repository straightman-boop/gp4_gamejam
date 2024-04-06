using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasManager : MonoBehaviour
{
    public bool isPaused = false;
    public bool isInventory = false;
    private void Awake()
    {
        menuManager.Init();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("GOT IN.");

            isPaused = !isPaused;
            if (isPaused)
            {
                menuManager.openMenu(menuList.SETTINGS, null);
                Debug.Log(menuManager.settingsMenu);
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
                menuManager.settingsMenu.SetActive(false);
            }
        }

        if(Input.GetKeyDown(KeyCode.I))
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
