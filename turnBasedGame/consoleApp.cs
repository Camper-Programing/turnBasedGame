using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.Config;
using turnBasedGame.logger;
using turnBasedGame.model.Attack;
using turnBasedGame.model.Creature;
using turnBasedGame.model.Defense;
using turnBasedGame.Factory;
using turnBasedGame.World;



namespace turnBasedGame //test class ´for the framework
{
    internal class ConsoleApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current directory: {Environment.CurrentDirectory}"); //to help debug file path issues
            //Test of logging
            MyLogger.Instance.addListener(new ConsoleTraceListener());

            //create world
            /*var World = new World.World(10, 10, MyLogger.Instance); the old way when the game created a world*/

            string configPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.xml");
            var (maxX, maxY, difficulty) = ConfigLoader.LoadConfig(configPath); //if it does not work use a hardcodeded path like @"C:\path\to\your\Config.xml"
            MyLogger.Instance.Log($"Game configuration loaded: maxX={maxX}, maxY={maxY}, difficulty={difficulty}");

            var World = new World.World(maxX, maxY, MyLogger.Instance); //new way where the world is created based on the config file

            


            //Add Items to Creature
            var hero = new Hero(1, 1, 150);
            var enemy = new Enemy(2, 2, 80);

            //Testing Observer Pattern
            hero.AddObserver(new LoggerObserver());
            enemy.AddObserver(new LoggerObserver());

            /*hero.AddAttackItem(new Sword());*/

            hero.AddAttackItem(GameObjectFactory.CreateAttackItem("Sword"));//Create Attack Item using factory with default damage that being 15


            var sword1 = GameObjectFactory.CreateAttackItem("Sword", 28); //Create Attack Item using factory with custom damage
            var sword2 = GameObjectFactory.CreateAttackItem("Sword", 19); //Create another Attack Item using factory with custom damage
            var combinedSword = (Sword)sword1 + (Sword)sword2; //Use operator overloading to combine swords
            hero.AddAttackItem(combinedSword); //Add combined sword to hero
            //Create Defense Items using factory.

            var swordEnemy = GameObjectFactory.CreateAttackItem("Sword", 20);
            enemy.AddAttackItem(swordEnemy);



            var boostedSheild = new DefenseDecorator(new Shield(), 5); //should add 5 points of damage protection, standard shield gives 10 points of protection
            var compositeDefense = new DefenseComposite();
            compositeDefense.Add(boostedSheild);
            enemy.AddDefenseItem(compositeDefense);

             //This is to test the decorator and composite pattern

             


            hero.PerformAttack(enemy); //Test Attack Hero to Enemy
            enemy.PerformAttack(hero);  //Test Attack Enemy to Hero

            //Test Attack Hero to Enemy
            /*hero.Hit(enemy);
            MyLogger.Instance.Log($"Enemy HP after hit: {enemy.HP}");
            Console.WriteLine($"Enemy HP after attack: {enemy.HP}");


            enemy.Hit(hero);
            MyLogger.Instance.Log($"Hero HP after hit: {hero.HP}");
            Console.WriteLine($"Hero HP after attack: {hero.HP}");*/ 
            
            //this part here should not be needed after the oberserver pattern is implemented but leaving it for now to see the output in console


            //Move Creature

            /*hero.MoveTo(4, 5);
            MyLogger.Instance.Log($"Creature moved to ({hero.PositionX}, {hero.PositionY})"); /* The first test has been concluded, had to change a few things here and there in order for it to work, one was mainly naming problems with the program*/
            //Console.WriteLine("Press any key to exit...check the log for details.");*/
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    } 
   
}
