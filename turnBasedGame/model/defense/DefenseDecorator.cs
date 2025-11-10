using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.model.Defense;

namespace turnBasedGame.model.Defense
{
    public class DefenseDecorator : IDefenseItem
    {
        private readonly IDefenseItem _baseDefense;
        private readonly int _extraProtection;

        public DefenseDecorator(IDefenseItem baseDefense, int extraProtection)
        {
            _baseDefense = baseDefense;
            _extraProtection = extraProtection;
        }
    


        public string Name => _baseDefense.Name + " + Boost";
        public int Protection => _baseDefense.Protection + _extraProtection;

        string IDefenseItem.Name { get => Name; set => throw new NotImplementedException(); }
    }
}
