using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.logger;
using turnBasedGame.model.Creature;

namespace turnBasedGame.logger
{
    public class LoggerObserver : ICreatureOberserver
    {
        public void OnCreatureHit(Creature creature, int damage) {


            MyLogger.Instance.Log(($"{creature.GetType().Name} was hit for {damage} damage. Remaining HP: {creature.HP}"));
        }
    }
}
