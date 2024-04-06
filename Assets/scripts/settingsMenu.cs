using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class settingsMenu : MonoBehaviour
{
    void Start()
    {
        menuManager.openMenu(menuList.SETTINGS, gameObject);
    }
}
