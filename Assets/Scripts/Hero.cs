using UnityEngine;

public class Hero : MonoBehaviour
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

    private int gold;

    public int Gold
    {
        get => gold; set => gold = (value < 0) ? 0 : (value > 999) ? 999 : value;
    }

    private int attackPower;
    public int AttackPower
    {
        get => attackPower; set => attackPower = value;
    }

    private int earnGold;

    //Constructor (For create object) in Unity use initialization
    public void Init(string newName, int newHp, int attackPower)
    {
        Name = newName;
        Health = newHp;
        AttackPower = attackPower;
        Gold = 0;
    }

    //Method
    public void ShowStats()
    {
        Debug.Log($"Hero name: {Name}, Health: {Health}, Attack Power: {AttackPower}, Gold: {Gold}, Alive Status: {IsAlive()}");
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

    public void EarnGold(int lootGold)
    {
        Gold += lootGold;
        Debug.Log($"{Name} get {Gold} Gold.");
    }

    public void Attack(Monster monster)
    {
        monster.TakeDamage(AttackPower);
    }
}