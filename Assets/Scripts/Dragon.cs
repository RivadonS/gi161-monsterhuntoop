using UnityEngine;

public class Dragon : Monster
{
    public override int LootGold => 50;

    public void InitializeDragon(string name)
    {
        base.Init(name, 100, 30);
    }

    public override void Roar()
    {
        Debug.Log($"Dragon Roar!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} Fire Blast , deal {AttackPower} Damage.");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
