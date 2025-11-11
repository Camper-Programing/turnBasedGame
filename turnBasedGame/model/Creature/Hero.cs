/// <sumary>
/// This is the hero class that inherits from the creature class.
/// for the hero class I decided to make it a bit more special, by saying the hero always does a flat +5 damage bonus on every attack.
/// </sumary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedGame.model.Creature
{
    public class Hero : Creature
    {
        public Hero(int x, int y, int hp) : base(x, y, hp) { }

        protected override int ApplySpecialBonus(int damage)
        {
           return damage + 5; // Heroes get a flat +5 damage bonus, cause he is the hero.
        }


    }
}
