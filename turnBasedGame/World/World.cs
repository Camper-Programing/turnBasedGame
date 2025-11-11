using System.Collections.Generic;
using System.Linq;
using turnBasedGame.model.Creature;
using turnBasedGame.logger;

namespace turnBasedGame.World
{
    /// <summary>
    /// Represents the world grid and manages creatures and world objects.
    /// </summary>
    public class World
    {
        private readonly Ilogger _logger;

        public int MaxX { get; }
        public int MaxY { get; }

        private readonly List<WorldObject> _worldObjects = new();
        private readonly List<Creature> _creatures = new();

        public World(int maxX, int maxY, Ilogger logger)
        {
            MaxX = maxX;
            MaxY = maxY;
            _logger = logger;
            _logger.Log($"World created with size {MaxX}x{MaxY}");
        }

        public void AddWorldObject(WorldObject obj)
        {
            _worldObjects.Add(obj);
            _logger.Log($"World object added at position ({obj.positionX}, {obj.positionY})");
        }

        public void AddCreature(Creature creature)
        {
            _creatures.Add(creature);
            _logger.Log($"Creature added at position ({creature.PositionX}, {creature.PositionY})");
        }

        public bool IsOccupied(int x, int y) =>
            _creatures.Any(c => c.PositionX == x && c.PositionY == y) ||
            _worldObjects.Any(o => o.positionX == x && o.positionY == y);
    }
}
