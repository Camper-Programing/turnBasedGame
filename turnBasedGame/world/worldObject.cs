using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedGame.world
{
    public class worldObject
    {
        public int positionX {  get; set; }
        public int positionY { get; set; }
        public bool isRemovalbe {  get; set; }

        public worldObject(int x, int y, bool isRemovalbe = true)
        {
            positionX = x;
            positionX = y;
            isRemovalbe = isRemovalbe;
        }
    }
}
