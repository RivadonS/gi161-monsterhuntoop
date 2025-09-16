using UnityEngine;

public class Monster : MonoBehaviour
{
    //Property
    private string name;
    public string Name
    {
        get => name; set => name = (string.IsNullOrEmpty(value)) ? "Unknown Monster Name" : value;
    }

    private int health;
    public int Health
    {
        get => health;
        set => health = (value < 0) ? 0 : value;
    }

    private bool isDefeated;

    private int attackPower;
    public int AttackPower
    {
        get => attackPower;
        set => attackPower = value;
    }

    private int lootGold;
    public int LootGold
    {
        get => lootGold;
        set => lootGold = value;
    }
    //Constructor
    public Monster(string newName, int newHp, int gold, int attackPower)
    {
        Name = newName;
        Health = newHp;
        LootGold = gold;
        AttackPower = attackPower;
        isDefeated = false;
    }

    //Method
    public void ShowStats()
    {
        Debug.Log($"Monster name: {Name}, Health: {Health}, lootgold: {LootGold}, attack power: {AttackPower}");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{Name} take {damage} damage. Current Health {Health}");
    }

    public void Attack(Hero hero)
    {
        hero.TakeDamage(AttackPower);
    }

    public bool IsAlive()
    {
        return (Health > 0);
    }

    public int DropReward()
    {
        return LootGold;
    }
}