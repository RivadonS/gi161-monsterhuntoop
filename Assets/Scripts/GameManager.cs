using NUnit.Framework.Constraints;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Hero hero1;
    public List<Monster> monsterPrefabs; //For Monster Prefabs
    public List<Monster> monsters = new List<Monster>(); //Monster
    public List<Weapon> weaponPrefabs;//For Weapon Prefabs
    public Monster currentMonster;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hero1.Init("Kratos", 100, 30);
        hero1.ShowStats();

        //Weapon
        Weapon sword = Instantiate(weaponPrefabs[0], new Vector3(5, 5, 5), Quaternion.identity);
        Weapon knuckle = Instantiate(weaponPrefabs[0], new Vector3(-5, 5, 5), Quaternion.identity);

        //Initialize Weapon
        sword.InitWeapon("Sword", 10);
        knuckle.InitWeapon("Dragon's Knuckle", 7);

        /*
        SpawnMonster(MonsterType.Goblin);
        SpawnMonster(MonsterType.Orc);
        SpawnMonster(MonsterType.Dragon);
        */

        //Goblin
        Monster goblinObj = Instantiate(monsterPrefabs[0]);
        Goblin goblin1 = goblinObj.GetComponent<Goblin>();
        if (goblin1 != null)
        {
            goblin1.InitializeGoblin("Yumi");
        }
        monsters.Add(goblinObj);

        //Orc
        Monster orcObj = Instantiate(monsterPrefabs[1]);
        Orc orc1 = orcObj.GetComponent<Orc>();
        if (orc1 != null)
        {
            orc1.InitializeOrc("Harry");
        }
        monsters.Add(orcObj);

        //Dragon
        Monster dragonObj = Instantiate(monsterPrefabs[2]);
        Dragon dragon1 = dragonObj.GetComponent<Dragon>();
        if (dragon1 != null)
        {
            dragon1.InitializeDragon("Lizardon");
        }
        monsters.Add(dragonObj);

        //Equip Weapon
        hero1.EquipWeapon(sword);
        monsters[2].EquipWeapon(knuckle);

        hero1.Attack(monsters[2],hero1.EquippedWeapon);
        monsters[2].Attack(hero1, monsters[2].EquippedWeapon);

        foreach (Monster m in monsters)
        {
            m.ShowStats();
            m.Roar();
            m.Attack(hero1);
        }

        /*
        Debug.Log("\n --battle--");
        hero1.ShowStats();
        hero1.Attack(currentMonster);
        currentMonster.ShowStats();
        currentMonster.Attack(hero1);
        hero1.Attack(currentMonster, 10);
        hero1.EarnGold(currentMonster.LootGold);
        hero1.Heal(5);
        hero1.ShowStats();
        */
    }

    /*public void SpawnMonster(MonsterType monsterType)
    {
        Monster monsterPrefab = monsterPrefabs[(int)monsterType]; //Convert Enum Value to list index

        Monster monsterObject = Instantiate(monsterPrefab);

        monsterObject.Init(monsterType);//Init by monster type

        monsters.Add(monsterObject);// Add instantiate (Monster object) to List monsters
    }
    */
}