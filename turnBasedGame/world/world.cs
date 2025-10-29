using turnBasedGame.model.creature;
using turnBasedGame.world;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace turnBasedGame.world
{
    public class world
    {
        public int maxX { get; set; }
        public int maxY { get; set; }

        private readonly List<worldObject> worldObjects;
        private readonly List<creature> creature;


    }
}
