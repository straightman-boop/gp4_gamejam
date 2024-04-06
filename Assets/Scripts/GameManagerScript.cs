using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public TextMeshProUGUI wheat;
    public TextMeshProUGUI barley;
    public TextMeshProUGUI berries;

    public static GameManagerScript gamemanager;
    [HideInInspector] public bool endCond;

    float globalTime;
    public float globalLimit = 2220;


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

        globalLimit = globalTime;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        globalTime -= Time.deltaTime;
        if(globalTime <= 0)
        {
            //Debug.Log("FINISH!");
        }
    }
}
