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
            var Creature = new Creature(2, 3);
            //World.AddCreature(Creature);//


            //Move Creature
            Creature.MoveTo(4, 5);
            MyLogger.Instance.Log($"Creature moved to ({Creature.positionX}, {Creature.positionY})");

            Console.WriteLine("Press any key to exit...check the log for details.");
            Console.ReadKey();
        }

    }
    /*public class Creature
    {
        public int positionX { get; private set; }
        public int positionY { get; private set; }
        public Creature(int x, int y)
        {
            positionX = x;
            positionY = y;
        }
        public void MoveTo(int x, int y)
        {
            positionX = x;
            positionY = y;


        }
    }*/
}
