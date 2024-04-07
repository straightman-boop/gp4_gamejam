using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public TextMeshProUGUI wheat;
    public TextMeshProUGUI barley;
    public TextMeshProUGUI berries;
    
    public int wheatBasket;
    public int barleyBasket;
    public int berriesBasket;

    public static GameManagerScript gamemanager;
    [HideInInspector] public int winCond;

    float globalTime = 0;
    public float globalLimit = 2220;

    public int winScore = 10;

    public GameObject winScreen;
    public GameObject loseScreen;

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
        //Debug.Log(wheatBasket);

        globalTime -= Time.deltaTime;
        if (globalTime <= 0)
        {
            //Debug.Log("FINISH!");
        }

        if (winScore <= (wheatBasket + barleyBasket + berriesBasket))
        {
            winCond = 1;
        }

        if (winCond == 1)
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f;
        }

        if(winCond == 2)
        {
            loseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
