using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        string value = GameManagerScript.gamemanager.wheat.text;
        int score = int.Parse(value);

        score++;

        GameManagerScript.gamemanager.wheat.text = score.ToString();

        Destroy(gameObject);
    }
}
