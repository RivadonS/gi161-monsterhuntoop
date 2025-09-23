using UnityEngine;
public enum MonsterType
{
    Goblin,
    Orc,
    Dragon
}

public class Monster : Character
{
    private bool isDefeated;

    private int lootGold;
    public int LootGold
    {
        get => lootGold;
        set => lootGold = value;
    }

    //Constructor
    public void Init(MonsterType monsterType)//Difference parameter (method overloading)
    {
        switch (monsterType)
        {
            case MonsterType.Goblin:
                base.Init("Goblin", 50, 10);
                LootGold = 5;
                break;
            case MonsterType.Orc:
                base.Init("Orc", 75, 20);
                LootGold = 10;
                break;
            case MonsterType.Dragon:
                base.Init("Dragon", 100, 30);
                LootGold = 15;
                break;
        }
        isDefeated = false;
    }

    //Method
    public override void ShowStats()
    {
        base.ShowStats();
        Debug.Log($"Name: {Name} Loot Gold: {LootGold}");
    }

    public int DropReward()
    {
        return LootGold;
    }

    /*
    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"Monster {Name} bite the hero {target.Name}");
    }
    */

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"Monster {Name} bite the hero {target.Name}");
    }

    public override void Attack(Character target, int bonusAttack)
    {
        int monsterBonusDamage = (AttackPower * 2) + (bonusAttack / 2);
        target.TakeDamage(monsterBonusDamage);
        Debug.Log($"Monster {Name} bite(crit!). Deal {monsterBonusDamage} damage to hero {target.Name}");
    }

    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }
}