using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedGame.model.Creature
{
    public interface ICreatureOberserver
    {
      void OnCreatureHit(Creature creature, int damage);
    }
}
