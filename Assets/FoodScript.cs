using System;
using Random = UnityEngine.Random;
using UnityEngine;
using UnityEngine.UIElements;

public class FoodScript : MonoBehaviour
{
    public GameObject foodSpawner;

    SpriteRenderer spriteRenderer;

    public Sprite[] sprites;

    public float speed = 5;

    public float duration = 0.5f;
    float timer;

    bool timerDone = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        transform.position = foodSpawner.transform.position;

        int chance = Random.Range(0, sprites.Length);

        spriteRenderer.sprite = sprites[chance];
    }

    private void Update()
    {
        Vector2 position = transform.position;
        position = new Vector2(position.x - speed * Time.deltaTime, position.y);
        transform.position = position;

        if (timer > 0 && timerDone == false)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            //Debug.Log("Done!");
            timerDone = true;
        }

        if (timerDone == true)
        {
            transform.position = foodSpawner.transform.position;
            timerDone = false;
            timer = duration;

            int chance = Random.Range(0, sprites.Length);

            spriteRenderer.sprite = sprites[chance];
        }

    }
}
