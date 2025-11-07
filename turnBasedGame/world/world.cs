using turnBasedGame.model.Creature;
using turnBasedGame.world;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace turnBasedGame.world
{
    public class world
    {
        private readonly Ilogger logger;
        public int maxX { get; set; }
        public int maxY { get; set; }

        private readonly List<WorldObject> WorldObjects = new ();
        private readonly List<Creature> Creature = new ();

        public world(int maxX, int maxY, Ilogger logger)
        {
            this.maxX = maxX;
            this.maxY = maxY;
            this.logger = logger;
            logger.Log($"World created with size {maxX}x{maxY}");

        }
        public void AddWorldObject(WorldObject obj)
        {
            WorldObjects.Add(obj);
            logger.Log($"World object added at position ({obj.positionX}, {obj.positionY})");
        }
        public void AddCreature(Creature Creature)
        {
            this.Creature.Add(Creature);
            logger.Log($"Creature added at position ({Creature.positionX}, {Creature.positionY})");
        }

        public bool IsOccupied(int x, int y)
        {
            return Creature.Any(c => c.positionX == x && c.positionY == y) ||
                   worldObjects.Any(o => o.positionX == x && o.positionY == y);
        }


    }
}
