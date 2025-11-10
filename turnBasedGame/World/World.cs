using turnBasedGame.model.Creature;

namespace turnBasedGame.World
{
    internal class World
    {
        private readonly Ilogger logger;
        public int maxX { get; set; }
        public int maxY { get; set; }

        private readonly List<WorldObject> WorldObjects = new ();
        private readonly List<Creature> Creature = new ();

        public World(int maxX, int maxY, Ilogger logger)
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
            logger.Log($"Creature added at position ({Creature.PositionX}, {Creature.PositionY})");
        }

        public bool IsOccupied(int x, int y)
        {
            return Creature.Any(c => c.PositionX == x && c.PositionY == y) ||
                   WorldObjects.Any(o => o.positionX == x && o.positionY == y);
        }


    }
}
