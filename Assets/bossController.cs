using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossController : MonoBehaviour
{
    public static bossController bossInstance;
    public float bossHealth;
    public Slider healthSlider;
    private void Awake()
    {
        healthSlider.value = bossHealth;
        if (bossInstance == null)
        {
            bossInstance = this;
        }
        else if (bossInstance != this)
        {
            Destroy(gameObject);
        }
    }
    public void minusBossHealth(float damage)
    {
        bossHealth = bossHealth + damage;
        healthSlider.value = bossHealth;
    }
}
