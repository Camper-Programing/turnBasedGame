using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedGame.model.Attack
{
    public interface IAttackItem
    {
        public string Name { get; set; }
        int Damage { get; }

    }

   


}
