using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedGame.Factory
{
    using turnBasedGame.model.Attack;
    using turnBasedGame.model.Defense;
    public static class GameObjectFactory
    {
        public static IAttackItem CreateAttackItem(string type, int damage = 15)
        {
            return type switch
            {
                "Sword" => new Sword(damage),
                _ => throw new ArgumentException($"Unknown attack item type: {type}"),
            };
        }
        public static IDefenseItem CreateDefenseItem(string type)
        {
            return type switch
            {
                "Shield" => new Shield(),
                _ => throw new ArgumentException($"Unknown defense item type: {type}"),
            };
        }
    }
}
