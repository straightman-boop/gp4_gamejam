using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarleyScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        string value = GameManagerScript.gamemanager.barley.text;
        int score = int.Parse(value);

        score++;

        GameManagerScript.gamemanager.barley.text = score.ToString();

        Destroy(gameObject);
    }
}
