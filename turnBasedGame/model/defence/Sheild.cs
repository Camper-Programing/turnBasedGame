using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.model.Defence;

namespace turnBasedGame.model.defence
{
    public class Sheild : IDefenseItem
    {
        public string Name => "Sheild";
        public int Protection => 10;
    
        string IDefenseItem.Name { get => Name; set => throw new NotImplementedException(); }
    }
}
