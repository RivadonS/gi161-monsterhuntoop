using UnityEngine;

public class Hero : Character
{
    //Property
    private int gold;

    public int Gold
    {
        get => gold; set => gold = (value < 0) ? 0 : (value > 999) ? 999 : value;
    }

    private int earnGold;

    //Constructor (For create object) in Unity use initialization
    /*
    public void Init(string newName, int newHp, int attackPower)
    {
        base.Init(newName, newHp, attackPower);
        Gold = 0;
    }
    */

    public override void Init(string newName, int newHp, int attackPower)//Same Name Same Parameter Difference Inside(Method Overriding)
    {
        base.Init(newName, newHp, attackPower);
        Gold = 0;
    }

    //Method
    public override void ShowStats()
    {
        base.ShowStats();
        Debug.Log($"Name: {Name}, Current Gold: {Gold}, IsAlive {IsAlive()}");
    }


    public void EarnGold(int lootGold)
    {
        Gold += lootGold;
        Debug.Log($"{Name} get {Gold} Gold.");
    }
}