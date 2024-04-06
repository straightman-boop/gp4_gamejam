using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryMenu : MonoBehaviour
{
    void Start()
    {
        menuManager.openMenu(menuList.INVENTORY, gameObject);
    }
}