using System;
using System.Collections.Generic;
using System.Linq;
using turnBasedGame.model.Attack;
using turnBasedGame.model.Defense;


namespace turnBasedGame.model.Creature
{
    

    public class Creature : ICreature
    {
      /*This here is to create the base line for a creature, adding things like items, hp, movement*/

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public int HP { get; private set; }


        private readonly List<IAttackItem> _attackItems = new();
        private readonly List<IDefenseItem> _defenseItems = new();

        
        

        public Creature(int positionX, int positionY, int hP)
        {
            PositionX = positionX;
            PositionY = positionY;
            HP = hP;
        }

      

        public void MoveTo(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
        public void AddAttackItem(IAttackItem item) => _attackItems.Add(item);
        public void AddDefenseItem(IDefenseItem item) => _defenseItems.Add(item);


        public void Hit(Creature target)
        {
            int totalDamage = _attackItems.Sum(item => item.Damage);
            target.ReceiveHit(totalDamage);
        }

        public void ReceiveHit(int damage)
        {
            int reducedDamage = Math.Max(0, damage - _defenseItems.Sum(item => item.Protection));
            HP -= reducedDamage;
        }
       

       
    }
}