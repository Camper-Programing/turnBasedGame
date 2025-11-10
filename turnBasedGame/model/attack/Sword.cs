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
        public int Damage => 15;

        string IAttackItem.Name { get => Name; set => throw new NotImplementedException(); }
    }
}
