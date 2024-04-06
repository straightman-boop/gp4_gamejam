using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantObjectScript : MonoBehaviour
{
    public float healthDuration = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthDuration -= Time.deltaTime;

        if (healthDuration <= 0)
        {
            Destroy(gameObject);
        }
    }


}
