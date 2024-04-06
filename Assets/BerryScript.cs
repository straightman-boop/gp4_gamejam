using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        string value = GameManagerScript.gamemanager.berries.text;
        int score = int.Parse(value);

        score++;

        GameManagerScript.gamemanager.berries.text = score.ToString();

        Destroy(gameObject);
    }
}
