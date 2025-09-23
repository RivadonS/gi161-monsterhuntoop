using System.Xml.Serialization;
using UnityEngine;

public class Hero : Character
{
    //Property
    private int gold;
    public int Gold { get; protected set; }
    /*
    public int Gold
    {
        get => gold; set => gold = (value < 0) ? 0 : (value > 999) ? 999 : value;
    }
    */

    private int earnGold;

    //Constructor (For create object) in Unity use initialization
    /*
    public void Init(string newName, int newHp, int attackPower)
    {
        base.Init(newName, newHp, attackPower);
        Gold = 0;
    }
    */

    public void Init(string newName, int newHp, int attackPower)//Same Name Same Parameter Difference Inside(Method Overriding)
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
        Gold = Mathf.Clamp(Gold + lootGold, 0, 999);
        Debug.Log($"Hero: {Name} get {Gold} Gold.");
    }

    public void Heal(int amount)
    {
        Health = Mathf.Clamp(Health + amount, 0, maxHealth);
        Debug.Log($"Hero: {Name} Heal: {amount} HP");
    }

    /*
    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"Hero {Name} attack monster {target.Name} ");
    }
    */

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"Hero {Name} attack monster {target.Name} ");
    }

    public override void Attack(Character target, int bonusAttack)
    {
        int heroBonusDamage = AttackPower + bonusAttack;
        Debug.Log($"Hero {Name} attack(Crit!) Deal {heroBonusDamage} damage to {target.Name}");
        target.TakeDamage(heroBonusDamage);
    }

    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }
}