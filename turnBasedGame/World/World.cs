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
        /// <summary>
        /// This is to log the events of the world
        /// </summary>
        /// <remarks> used internally for logging use.</remarks>
        private readonly Ilogger _logger;

        /// <summary>
        /// Initializes a new instance of the World class with specified dimensions.
        /// </summary>
        /// <param name="maxX">The maximum X-coordinate of the world.</param>
        /// <param name="maxY">The maximum Y-coordinate of the world.</param>

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

        /// <summary>
        /// adds a world object to the world
        /// </summary>
        /// <param name="obj"></param>
        public void AddWorldObject(WorldObject obj)
        {
            _worldObjects.Add(obj);
            _logger.Log($"World object added at position ({obj.positionX}, {obj.positionY})");
        }
        /// <summary>
        /// adds a creature to the world
        /// </summary>
        /// <param name="creature"></param>
        public void AddCreature(Creature creature)
        {
            _creatures.Add(creature);
            _logger.Log($"Creature added at position ({creature.PositionX}, {creature.PositionY})");
        }
        /// <summary>
        /// to check it a postion on the map/world is occupied
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsOccupied(int x, int y) =>
            _creatures.Any(c => c.PositionX == x && c.PositionY == y) ||
            _worldObjects.Any(o => o.positionX == x && o.positionY == y);
    }
}
