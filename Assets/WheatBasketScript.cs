using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WheatBasketScript : MonoBehaviour
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
        //Debug.Log(GameManagerScript.gamemanager.wheat.text);
        //Debug.Log(int.Parse(GameManagerScript.gamemanager.wheat.text));


        if (Input.GetKeyDown(KeyCode.E) && entered == true)
        {
            Debug.Log("ENTERED! PRIMARY");
            if (int.Parse(GameManagerScript.gamemanager.wheat.text) > 0)
            {
                Debug.Log("ENTERED!");
                GameManagerScript.gamemanager.wheatBasket += int.Parse(GameManagerScript.gamemanager.wheat.text);
                GameManagerScript.gamemanager.wheat.text = "0";
            }

            else if(int.Parse(GameManagerScript.gamemanager.wheat.text) <= 0)
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

