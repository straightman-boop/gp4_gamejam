using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storeFood : MonoBehaviour
{
    public static storeFood storeFoodInstance;

    public int freshFoodStored=0, rottenFoodStored=0;

    private void Awake()
    {
        if(storeFoodInstance == null)
        {
            storeFoodInstance = this;
        }
        else if (storeFoodInstance != this)
        {
            Destroy(gameObject);
        }
    }

}
