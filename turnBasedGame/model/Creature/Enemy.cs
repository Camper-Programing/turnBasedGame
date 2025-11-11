/// <summary>
/// this class represents an Enemy creature in the turn-based game. Like the hero class it inherits from the creature class.
/// It does not have any special bonus for now.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedGame.model.Creature
{
    public class Enemy : Creature
    {
        public Enemy(int x, int y, int hp) : base(x, y, hp) { }

        protected override int ApplySpecialBonus(int damage)
        {
           return damage; // Enemies have no special bonus for now.
        }


    }
}
