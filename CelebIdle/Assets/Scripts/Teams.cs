using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teams : MonoBehaviour
{
    public Player[] players;
    public int TotalPower;

    public bool IsTeamAlive{ get; set; }
    // Start is called before the first frame update

    private void Awake()
    {
        CalculateScore();
    }
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

    public Player GetFirstAlivePlayer()
    {
        foreach (var player in players)
        {
            if (player.IsAlive)
            {
                return player;
            }
        }
        return null;
    }
}
