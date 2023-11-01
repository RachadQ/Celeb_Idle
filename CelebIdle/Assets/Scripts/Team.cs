using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    Player[] players;
    public int TotalPower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CalculateScore()
    {
        foreach (var players in players)
        {
            TotalPower += players.PowerLevel;
        }
    }
}
