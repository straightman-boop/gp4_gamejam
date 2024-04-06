using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerStatsScript : MonoBehaviour
{
    public static PlayerStatsScript playerstats;

    public int playerLife;
    public int maxLife;

    public Image[] life;
    public Sprite fullLife;
    public Sprite emptyLife;

    private void Awake()
    {
        if (playerstats == null)
        {
            playerstats = this;
        }

        else if (playerstats != this)
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
        UpdateLife();
    }

    void UpdateLife()
    {
        if (playerLife > maxLife)
        {
            playerLife = maxLife;
        }

        for (int i = 0; i < life.Length; i++)
        {
            if (i < playerLife)
            {
                life[i].sprite = fullLife;
            }

            else
            {
                life[i].sprite = emptyLife;
            }

            if (i < maxLife)
            {
                life[i].enabled = true;
            }

            else
            {
                life[i].enabled = false;
            }
        }

    }
}
