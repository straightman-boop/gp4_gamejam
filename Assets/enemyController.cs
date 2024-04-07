using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyController : MonoBehaviour
{
    public float enemyHealth;
    public float speed;
    public bool vertical;
    public float changeTime = 3.0f;
    Rigidbody2D rigidbody2d; float timer;
    int direction;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction = -direction; 
            timer= changeTime;
        }
    }
    void FixedUpdate()
    {
        Vector2 position =rigidbody2d.position;
        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed* direction;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
                    }
        rigidbody2d.MovePosition(position);
    }
}