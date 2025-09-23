using NUnit.Framework.Constraints;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Hero hero1;
    public List<Monster> monsterPrefabs; //For Prefabs
    public List<Monster> monsters = new List<Monster>(); //Monster
    public Monster currentMonster;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hero1.Init("Kratos", 100,30);
        hero1.ShowStats();

        SpawnMonster(MonsterType.Goblin);
        SpawnMonster(MonsterType.Orc);
        SpawnMonster(MonsterType.Dragon);

        currentMonster = monsters[0];

        Debug.Log("\n --battle--");
        hero1.ShowStats();
        hero1.Attack(currentMonster);
        currentMonster.ShowStats();
        currentMonster.Attack(hero1);
        hero1.Attack(currentMonster, 10);
        hero1.EarnGold(currentMonster.LootGold);
        hero1.Heal(5);
        hero1.ShowStats();
    }

    public void SpawnMonster(MonsterType monsterType)
    {
        Monster monsterPrefab = monsterPrefabs[(int)monsterType]; //Convert Enum Value to list index

        Monster monsterObject = Instantiate(monsterPrefab);

        monsterObject.Init(monsterType);//Init by monster type

        monsters.Add(monsterObject);// Add instantiate (Monster object) to List monsters
    }
}