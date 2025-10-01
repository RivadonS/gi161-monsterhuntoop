using UnityEngine;

public class Goblin : Monster
{
    public override int LootGold => 5;

    public void  InitializeGoblin(string name)
    {
        base.Init(name, 50, 10);
    }

    public override void Roar()
    {
        Debug.Log($"Goblin Roar!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} Kick, deal {AttackPower} Damage.");
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
