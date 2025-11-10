using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.logger;
using turnBasedGame.model.Creature;
using turnBasedGame.World;


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
            var Creature = new Creature(2, 3, 100);
            //World.AddCreature(Creature);//

            var hero = new Hero(1, 1, 150);
            var enemy = new Enemy(5, 5, 80);

            hero.AddAttackItem(new Sword(25));
            enemy.AddDefenseItem(new Sheild(10));



            //Move Creature
            Creature.MoveTo(4, 5);
            MyLogger.Instance.Log($"Creature moved to ({Creature.PositionX}, {Creature.PositionY})");

            Console.WriteLine("Press any key to exit...check the log for details.");
            Console.ReadKey();
        }

    } /* The first test has been concluded, had to change a few things here and there in order for it to work, one was mainly naming problems with the program*/
   
}
