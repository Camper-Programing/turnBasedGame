namespace turnBasedGame.model.Creature
{
    public interface ICreature
    {
        int positionX { get; }
        int positionY { get; }
        int HP { get; }
        void moveTo(int x, int y);
        void hit(Creature target, int damage);
        void ReveiveHit(int damage);
    }
    public class Creature : ICreature
    {
        private int v1;
        private int v2;

        public int positionX { get; private set; }
        public int positionY { get; private set; }
        public int HP { get; private set; }

        public Creature(int PositionX, int PositionY, int hP)
        {
            positionX = PositionX;
            positionY = PositionY;
            HP = hP;
        }

        public Creature(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public void MoveTo(int x, int y)
        {
            positionX = x;
            positionY = y;
        }



        public void ReveiveHit(int damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                //implément observer later
            }
        }
        public void hit(Creature target, int damage)
        {
            target.ReveiveHit(damage);
        }

        public void moveTo(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}