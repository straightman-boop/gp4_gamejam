using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillarController : MonoBehaviour
{
    void damageBoss()
    {//just customize this or smthn
        bossController.bossInstance.minusBossHealth(-4);
    }
}
