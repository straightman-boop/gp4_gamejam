using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMoveScript : MonoBehaviour
{
    public float speed = 3;

    public float duration = 0.5f;
    float timer;

    bool timerDone = false;

    public GameObject spawnpoint;

    private void Start()
    {
        timer = duration;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position = new Vector2(position.x + speed * Time.deltaTime, position.y);
        transform.position = position;


        if (timer > 0 && timerDone == false)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Done!");
            timerDone = true;
        }

        if( timerDone == true)
        {
            transform.position = spawnpoint.transform.position;
            timerDone = false;
            timer = duration;
        }

    }
}
