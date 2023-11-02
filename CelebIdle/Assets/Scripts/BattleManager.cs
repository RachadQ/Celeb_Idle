using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public Teams playerTeam;
    public Teams enemyTeam;
    public float countdownTime = 78f;

    private bool isPlayerTurn = true; // Indicates whose turn it is
    void StartBattle() {

        Debug.Log("Battle Start!");

        while (playerTeam.IsTeamAlive && enemyTeam.IsTeamAlive)
        {

            if (isPlayerTurn)
            {
                Player playerAttacker = playerTeam.GetFirstAlivePlayer();
                Player enemyTarget = enemyTeam.GetFirstAlivePlayer();

                if (playerAttacker != null && enemyTarget !=null)
                {
                    playerAttacker.Attack(enemyTarget);
                    Debug.Log(playerAttacker.Name + "attacks" + enemyTarget.Name + " For" + (playerAttacker.AttackPower - enemyTarget.Defense) + " damage.");
                }
            }
            else
            {
                Player enemyAttacker = enemyTeam.GetFirstAlivePlayer();
                Player playerTarget = playerTeam.GetFirstAlivePlayer();

                if (enemyAttacker != null && playerTarget != null)
                {
                    enemyAttacker.Attack(playerTarget);
                    Debug.Log(enemyAttacker.Name + " attacks " + playerTarget.Name + " for " + (enemyAttacker.AttackPower - playerTarget.Defense) + " damage.");
                }

            }

            isPlayerTurn = !isPlayerTurn; // Switch turns
        }

        if (!playerTeam.IsTeamAlive)
            Debug.Log("Player team has been defeated.");
        else if (!enemyTeam.IsTeamAlive)
            Debug.Log("Enemy team has been defeated.");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownTime > 0)
        {
            countdownTime -= Time.deltaTime;
            
        }
        else
        {
            countdownTime = 0;
           
            
        }
    }
}
