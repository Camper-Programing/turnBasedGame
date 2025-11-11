using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.model.Attack;

namespace turnBasedGame.model.Creature
{
    public interface ICreature
    {
        int PositionX { get; }
        int PositionY { get; }
        int HP { get; }
        void MoveTo(int x, int y);
       
        void ReceiveHit(int damage);

        void PerformAttack(Creature target);
    }
}
