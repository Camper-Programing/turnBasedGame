using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.logger;

namespace turnBasedGame //test class ´for the framework
{
    class consoleApp
    {
        static void Main(string[] args)
        {
            //Test of logging
            MyLogger.Instance.addListener(new ConsoleTraceListener());

            //create world
            var world = new world(10,10,MyLogger.Instance);

            var creature = new creature(2, 3);
            world.Add(creature);

        }
    }
}
