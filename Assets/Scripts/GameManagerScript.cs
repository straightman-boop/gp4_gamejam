using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript gamemanager;
    [HideInInspector] public bool endCond;

    private void Awake()
    {
        if (gamemanager == null)
        {
            gamemanager = this;
        }

        else if (gamemanager != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
