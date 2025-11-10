using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.logger;
using turnBasedGame.model.Creature;
using turnBasedGame.World;
using turnBasedGame.model.Attack;
using turnBasedGame.model.Defense;



namespace turnBasedGame //test class ´for the framework
{
    internal class ConsoleApp
    {
        static void Main(string[] args)
        {
            //Test of logging
            MyLogger.Instance.addListener(new ConsoleTraceListener());

            //create world
            var World = new World.World(10, 10, MyLogger.Instance);

            //create Creature
            /*var Creature = new Creature(2, 3, 100);*/
            //World.AddCreature(Creature);//

            var hero = new Hero(1, 1, 150);
            var enemy = new Enemy(5, 5, 80);
            
            hero.AddAttackItem(new Sword());

            var shield = new Shield();
            var boostedSheild = new DefenseDecorator(shield, 0); //should add 10 points of damage protection
            var compositeDefense = new DefenseComposite();
            compositeDefense.Add(shield);
            compositeDefense.Add(boostedSheild); //This is to test the decorator and composite pattern

            //Add Items to Creature

            enemy.AddDefenseItem(compositeDefense);

            //Add Creature to World
            World.AddCreature(hero);
            World.AddCreature(enemy);

            //Test Attack Hero to Enemy
            hero.Hit(enemy);
            MyLogger.Instance.Log($"Enemy HP after hit: {enemy.HP}");
            Console.WriteLine($"Enemy HP after attack: {enemy.HP}");

            enemy.Hit(hero);
            MyLogger.Instance.Log($"Hero HP after hit: {hero.HP}");


            //Move Creature

            /*hero.MoveTo(4, 5);
            MyLogger.Instance.Log($"Creature moved to ({hero.PositionX}, {hero.PositionY})"); /* The first test has been concluded, had to change a few things here and there in order for it to work, one was mainly naming problems with the program*/
            //Console.WriteLine("Press any key to exit...check the log for details.");*/
            Console.ReadKey();
        }

    } 
   
}
