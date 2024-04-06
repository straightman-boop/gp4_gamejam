using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class containerMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        menuManager.openMenu(menuList.CONTAINERS, gameObject);
    }
}
