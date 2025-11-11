using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.model.Attack;

namespace turnBasedGame.model.Attack
{
    public class Sword : IAttackItem
    {
        public string Name => "Sword";
        public int Damage { get; }

        public Sword(int damage = 15)
        {
            Damage = damage;
        }

        public static Sword operator +(Sword a, Sword b)
        {
            return new Sword(a.Damage + b.Damage);
        }

        string IAttackItem.Name { get => Name; set => throw new NotImplementedException(); }
    }
}
