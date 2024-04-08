using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    public GameObject interact;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interact.gameObject.SetActive(true);
        if (collision.gameObject.tag=="fineFood"||collision.gameObject.tag=="rottenFood")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (collision.gameObject.tag == "fineFood")
                {
                    Debug.Log("fine food collected");
                    storeFood.storeFoodInstance.freshFoodStored += 1;
                }
                else if (collision.gameObject.tag == "rottenFood")
                {
                    Debug.Log("rotten food collected");
                    storeFood.storeFoodInstance.rottenFoodStored += 1;
                }
                Destroy(collision.gameObject);
                Debug.Log("deleted");
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (interact.gameObject != null)
        {
            if (interact.gameObject.activeSelf)
            {
                interact.gameObject.SetActive(false);
            }
        }

        
        
    }
}
