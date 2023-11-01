using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Player : MonoBehaviour
{
    #region Max Stats
    public int MaxHealth { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }
    #endregion

    #region Game State Stats
    public int CurrentHealth { get; set; }
    public int XP { get; set; }
    public bool IsAlive { get; set; }
    #endregion
    public string Name { get; set; }
   


    public int PowerLevel { get; set; }

    public CharacterClass CharacterClass { get; set; }


    public Player(string name, int maxHealth, int attackPower, int defense)
    {
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        AttackPower = attackPower;
        Defense = defense;
        IsAlive = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(Player target)
    {
        int damage = Mathf.Max(AttackPower - target.Defense, 0);
        target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            IsAlive = false;
        }
    }

}
