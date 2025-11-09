using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedGame.World
{
    internal class WorldObject
    {
        public int positionX {  get; private set; }
        public int positionY { get; private set; }
        public bool IsRemovalbe {  get; private set; }

        public WorldObject(int x, int y, bool isRemovalbe = true)
        {
            positionX = x;
            positionX = y;
            IsRemovalbe = isRemovalbe;
        }
    }
}
