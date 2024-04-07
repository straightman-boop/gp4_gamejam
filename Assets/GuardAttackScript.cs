using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardAttackScript : MonoBehaviour
{
    public static GuardAttackScript guardAttack;
    public Animator animator;

    private void Awake()
    {
        if (guardAttack == null)
        {
            guardAttack = this;
        }

        else if (guardAttack != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void whipAttack()
    {
        animator.SetTrigger("Attack");
    }
}
