using UnityEngine;

public abstract class Character : MonoBehaviour //Abstract can't use to construct
{
    //Property
    private string name;
    public string Name
    {
        get => name; set => name = (string.IsNullOrEmpty(value)) ? "Unknown Hero Name" : value;
    }

    private int health;
    public int Health
    {
        get => health; set => health = (value < 0) ? 0 : value;
    }

    private int attackPower;
    public int AttackPower
    {
        get => attackPower; set => attackPower = value;
    }

    //Constructor (For create object) in Unity use initialization
    public virtual void Init(string newName, int newHp, int attackPower) //Virtual
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
        Health -= damage;
        Debug.Log($"{Name} take {damage} damage. Current Health {Health}");
    }

    public bool IsAlive()
    {
        return (health > 0);
    }

    public void Attack(Monster monster)
    {
        monster.TakeDamage(AttackPower);
    }
}
