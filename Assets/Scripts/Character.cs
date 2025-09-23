using System.Xml.Serialization;
using UnityEngine;

public abstract class Character : MonoBehaviour //Abstract can't use to construct
{
    //Property
    private string name;
    public string Name
    {
        get => name; set => name = (string.IsNullOrEmpty(value)) ? "Unknown Name" : value;
    }
    protected int maxHealth = 100;
    public int Health { get; protected set; }
    /*
    private int health;
    public int Health
    {
        get => health; set => health = (value < 0) ? 0 : value;
    }
    */

    private int attackPower;
    public int AttackPower
    {
        get => attackPower; set => attackPower = value;
    }

    //Constructor (For create object) in Unity use initialization
    public void Init(string newName, int newHp, int attackPower) //Virtual
    {
        Name = newName;
        Health = newHp;
        AttackPower = attackPower;
    }

    //Method
    public virtual void ShowStats()
    {
        Debug.Log($"Name: {Name}, Health: {Health}, Attack Power: {AttackPower}");
    }
    public void TakeDamage(int damage)
    {
        //Health -= damage;
        Health = Mathf.Clamp(Health - damage, 0 , maxHealth);
       /*if (Health < 0) Health = 0;
        else  if (Health > maxHealth) Health = maxHealth;*/
        Debug.Log($"{Name} take {damage} damage. Current Health {Health}");
    }

    public bool IsAlive()
    {
        return (Health > 0);
    }

    /*
    public virtual void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
    }
    */

    //Abstract
    public abstract void Attack(Character target);
    //Method Overloading
    public abstract void Attack(Character target, int bonusAttack);

    public abstract void OnDefeated();
}
