using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnBasedGame.model.Defense; 



namespace turnBasedGame.model.Defense
{
    public class Shield : IDefenseItem
    {
        public string Name => "Shield";
        public int Protection => 10;
    
        string IDefenseItem.Name { get => Name; set => throw new NotImplementedException(); }
    }
}
