using UnityEngine;

public class Orc : Monster
{
    public override int LootGold => 10;

    public void InitializeOrc(string name)
    {
        base.Init(name, 75, 20);
    }

    public override void Roar()
    {
        Debug.Log($"Orc Roar!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} pinch nipples , deal {AttackPower} Damage.");
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
