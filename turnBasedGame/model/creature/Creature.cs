///<summary>
///This class is a representation of a Creature in the turn-based game.
///Represents a creature with position, health points (HP), attack items, defense items, and observer functionality.
///It provides methods to move, attack others, receive hits, and manage items and observers
/// </summary>



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


        private readonly List<IAttackItem> _attackItems = new(); // List to hold attack items
        private readonly List<IDefenseItem> _defenseItems = new(); // List to hold defense items

        private readonly List<ICreatureOberserver> _observers = new();// List to hold observers

        /// <summary>
        /// Initializes a new instance of the Creature class with specified position and health points.
        /// <param name="positionX">The X coordinate of the creature's position.</param>
        /// <param name="positionY">The Y coordinate of the creature's position.</param>
        /// <param name="hP">The health points (HP) of the creature.</param>

        public Creature(int positionX, int positionY, int hP)
        {
            PositionX = positionX;
            PositionY = positionY;
            HP = hP;
        }


        /// <summary>
        /// Moves the creature to a new position in the world.
        /// </summary>
        /// <param name="x">The new X-coordinate.</param>
        /// <param name="y">The new Y-coordinate.</param>



        public void MoveTo(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
        public void AddAttackItem(IAttackItem item) => _attackItems.Add(item);
        public void AddDefenseItem(IDefenseItem item) => _defenseItems.Add(item);
        public void AddObserver(ICreatureOberserver observer) => _observers.Add(observer);
        public void RemoveObserver(ICreatureOberserver observer) => _observers.Remove(observer);
        /// <summary>
        /// This is for performing an attack, that makes use of a templete method pattern
        /// </summary>
        /// <param name="target"> a target creature to attack</param>
        /// <returns></returns>

        public void PerformAttack(Creature target) // Attack another creature new method templated for observer pattern and special bonuses
        {
            int Damage = CalculateDamage();
            Damage = ApplySpecialBonus(Damage);
            target.ReceiveHit(Damage);
            
        }

       

        protected virtual int CalculateDamage() // Calculate total damage from attack items
        {
            return _attackItems.Sum(item => item.Damage);
        }
        protected virtual int ApplySpecialBonus(int damage) // Placeholder for special bonus logic
        {
            return damage; // No bonus by default
        }
        
        /// <summary>
        /// Recalculate damage including special bonuses
        /// Notifies observers about the attack
        /// 
        /// </summary>
        /// <param name="damage" the incomingdamge before reduction ></param>
        /// <returns></returns>
        public void ReceiveHit(int damage) // Receive hit and reduce HP based on defense items, with observer notification
        {
            int reducedDamage = Math.Max(0, damage - _defenseItems.Sum(item => item.Protection));
            HP -= reducedDamage;
            
            foreach (var observer in _observers)
            {
                observer.OnCreatureHit(this, reducedDamage);
            }
        }

        /*public void Hit(Creature target) // Attack another creature a simple sum of all attack items damage, kept for logging purposes.
        {
            int totalDamage = _attackItems.Sum(item => item.Damage);
            target.ReceiveHit(totalDamage);
        }

        public void ReceiveHit(int damage) // Receive hit and reduce HP based on defense items, with observer notification, kept for logging purposes.
        {
            int reducedDamage = Math.Max(0, damage - _defenseItems.Sum(item => item.Protection));
            HP -= reducedDamage;

            foreach (var observer in _observers)
            {
                observer.OnCreatureHit(this, reducedDamage);
            }
        }*/



    }
}