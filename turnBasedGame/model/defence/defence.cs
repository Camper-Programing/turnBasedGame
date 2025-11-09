using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedGame.model.Defence
{
       public interface IDefenseItem
    {
        public string Name { get; set; }
        int Protection { get; }
    }

  

}
