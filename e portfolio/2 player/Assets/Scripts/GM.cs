using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public int P1Life;
    public int P2Life;

    public GameObject P1Wins;
    public GameObject P2Wins;

    public GameObject[] p1H;
    public GameObject[] p2H;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (P1Life <= 0)
        {
            player1.SetActive(false);
            P2Wins.SetActive(true);

        }
        if (P2Life <= 0)
        {
            player2.SetActive(false);
            P1Wins.SetActive(true);

        }
    }

    public void HurtP1()
    {
        P1Life -= 1;

        for (int i = 0; i < p1H.Length; i++)
        {
            if (P1Life > i)
            {
                p1H[i].SetActive(true);
            }
            else
            {
                p1H[i].SetActive(false);
            }
        }
    }

    public void HurtP2()
    {
        P2Life -= 1;

        for (int i = 0; i < p2H.Length; i++)
        {
            if (P2Life > i)
            {
                p2H[i].SetActive(true);
            }
            else
            {
                p2H[i].SetActive(false);
            }
        }
    }
}
