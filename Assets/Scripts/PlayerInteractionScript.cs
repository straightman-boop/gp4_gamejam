using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    public GameObject interact;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interact.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interact.gameObject.SetActive(false);
    }
}
