using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class menuManager
{
    public static bool isInitialised { get; private set; }
    public static GameObject youLose, youWin, settingsMenu,containers, inventory;
    public static void Init()
    {//match case
        GameObject canvas = GameObject.Find("Canvas");
        youLose = canvas.transform.Find("You Lose").gameObject;
        settingsMenu = canvas.transform.Find("Settings").gameObject;
        youWin = canvas.transform.Find("You Win").gameObject;
        containers = canvas.transform.Find("Containers").gameObject;
        inventory = canvas.transform.Find("Inventory").gameObject;

        isInitialised = true;
    }
    public static void openMenu(menuList Menu, GameObject callObject)
    {
        if (!isInitialised)
        {
            Init();
        }
        switch (Menu)
        {
            case menuList.YOU_LOSE:
                youLose.SetActive(true);
                break;
            case menuList.SETTINGS:
                settingsMenu.SetActive(true);
                break;
            case menuList.YOU_WIN:
                youWin.SetActive(true);
                break;
            case menuList.INVENTORY: 
                inventory.SetActive(true); 
                break;
            case menuList.CONTAINERS: 
                containers.SetActive(true);
                break;
        }
        if (callObject == null)
        {
            Debug.Log("object null");
            return;
        }
        callObject.SetActive(false);
    }
}
