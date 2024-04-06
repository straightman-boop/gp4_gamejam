using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youLoseMenu : MonoBehaviour
{
    private void Start()
    {
        menuManager.openMenu(menuList.YOU_LOSE, gameObject);
    }
}
