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
        hero1.Init("Kratos", 100,  30);
        hero1.ShowStats();

        currentMonster = Instantiate(monsterPrefabs[0]);
        currentMonster.Init("Goblin", 50, 0, 5);
        monsters.Add(currentMonster);
        currentMonster.ShowStats();

        currentMonster = Instantiate(monsterPrefabs[1]);
        currentMonster.Init("Orc", 75, 0, 10);
        monsters.Add(currentMonster);
        currentMonster.ShowStats();

        currentMonster = Instantiate(monsterPrefabs[2]);
        currentMonster.Init("Dragon", 100, 0, 15);
        monsters.Add(currentMonster);
        currentMonster.ShowStats();

        /*
        //Create hero object
        Hero hero = new Hero("Kratos", 100, 50);
        //Create a list to hold monster objects
        List<Monster> monsters = new List<Monster>();
        //Create new monster
        monsters.Add(new Monster("Orc", 70, 50, 20));
        monsters.Add(new Monster("Goblin", 80, 60, 30));
        monsters.Add(new Monster("Dragon", 90, 70, 40));

        //print attributes
        hero.ShowStats();
        foreach (Monster monster in monsters)
        {
            monster.ShowStats();
        }

        //Battle
        hero.Attack(monsters[0]);
        monsters[0].Attack(hero);
        */
    }

    // Update is called once per frame
    void Update()
    {
    }
}