using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    Vector2 movement;
    float moveSpd = 7;

    bool faceRight = true;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement keys

        var A = Input.GetKey(KeyCode.A);
        var D = Input.GetKey(KeyCode.D);
        var S = Input.GetKey(KeyCode.S);
        var W = Input.GetKey(KeyCode.W);

        if (A || D)
        {
            if (D)
            {
                movement.x = 1;
                //Debug.Log(animator.speed);

                if (faceRight == false)
                {
                    flip();
                    //animator.SetBool("Right", true);
                }

            }

            else
            {
                movement.x = -1;
                //animator.SetInteger("X", -1);
                //animator.SetInteger("Speed2", 5);
                //Debug.Log(animator.speed);

                if (faceRight == true)
                {
                    flip();
                    //animator.SetBool("Right", false);
                }
            }

        }

        else
        {
            movement.x = 0;

            //animator.SetInteger("X", 0);
            //animator.SetInteger("Speed2", 0);

        }

        if (W || S)
        {
            if (W)
            {
                movement.y = 1;

                //animator.SetInteger("Y", 1);
                //animator.SetInteger("Speed", 5);

            }

            else
            {
                movement.y = -1;

                //animator.SetInteger("Y", -1);
                //animator.SetInteger("Speed", 5);

            }
        }

        else
        {
            movement.y = 0;

            //animator.SetInteger("Y", 0);
            //animator.SetInteger("Speed", 0);
        }
    }

    private void FixedUpdate()
    {
        //Movement physics
        rb.MovePosition(rb.position + movement * moveSpd * Time.fixedDeltaTime);
    }

    void flip()
    {
         faceRight = !faceRight;
         transform.Rotate(0f, 180f, 0);
    }


}
