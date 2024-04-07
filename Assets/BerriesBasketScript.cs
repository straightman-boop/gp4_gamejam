using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerriesBasketScript : MonoBehaviour
{
    public GameObject player;
    PlayerMovementScript playerMovementScript;

    bool entered;

    private void Start()
    {
        playerMovementScript = player.GetComponent<PlayerMovementScript>();
    }

    private void Update()
    {
        Debug.Log(GameManagerScript.gamemanager.berries.text);
        Debug.Log(int.Parse(GameManagerScript.gamemanager.berries.text));


        if (Input.GetKeyDown(KeyCode.E) && entered == true)
        {
            Debug.Log("ENTERED! PRIMARY");
            if (int.Parse(GameManagerScript.gamemanager.berries.text) > 0)
            {
                Debug.Log("ENTERED!");
                GameManagerScript.gamemanager.berriesBasket = int.Parse(GameManagerScript.gamemanager.berries.text);
                GameManagerScript.gamemanager.berries.text = "0";
            }

            else if (int.Parse(GameManagerScript.gamemanager.berries.text) <= 0)
            {
                GuardAttackScript.guardAttack.whipAttack();
                StartCoroutine(playerMovementScript.Blink(player));
                PlayerStatsScript.playerstats.playerLife--;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        entered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        entered = false;
    }
}
