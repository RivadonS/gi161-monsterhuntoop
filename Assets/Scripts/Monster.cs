using UnityEngine;

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
    public void Init(string newName, int newHp, int gold, int attackPower)//Difference parameter (method overloading)
    {
        base.Init(newName, newHp, attackPower);
        LootGold = gold;
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
}