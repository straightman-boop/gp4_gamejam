using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youWinMenu : MonoBehaviour
{
    private void Start()
    {
        menuManager.openMenu(menuList.YOU_WIN, gameObject);
    }
}
