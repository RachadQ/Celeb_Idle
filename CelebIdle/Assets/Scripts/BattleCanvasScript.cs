using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BattleCanvasScript : MonoBehaviour
{

    public TMP_Text attackerScore;
    public TMP_Text defenderScore;
    public TMP_Text timertext;

    public BattleManager battleManager;
    // Start is called before the first frame update
    private void Awake()
    {
       

    }
    void Start()
    {

        if (battleManager != null)
        {
            Debug.Log(battleManager.playerTeam.TotalPower.ToString());
            Debug.Log(battleManager.enemyTeam.TotalPower.ToString());
            attackerScore.text = battleManager.playerTeam.TotalPower.ToString();
            defenderScore.text = battleManager.enemyTeam.TotalPower.ToString();
            timertext.text = battleManager.countdownTime.ToString();

        }
        else
        {

            //Assign battle manager if not found
            Debug.LogWarning("MyScript is not attached to this GameObject.");
            GameObject gameObjectWithTag = GameObject.FindWithTag("BM");
            battleManager = gameObjectWithTag.GetComponent<BattleManager>();
            timertext.text = battleManager.countdownTime.ToString();

            attackerScore.text = battleManager.playerTeam.TotalPower.ToString();
            defenderScore.text = battleManager.playerTeam.TotalPower.ToString();


        }
    }

     void DisplayTime(int timeToDisplay)
    {
        int minutes = timeToDisplay / 60;
        int seconds = timeToDisplay % 60;

        timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    // Update is called once per frame
    void Update()
    {

        DisplayTime((int)battleManager.countdownTime);
    }
}
