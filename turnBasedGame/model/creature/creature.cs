namespace turnBasedGame.model.creature
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
        public int positionX { get; private set; }
        public int positionY { get; private set; }
        public int HP { get; private set; }

        public Creature(int positionX, int positionY, int hP)
        {
            positionX = positionX;
            positionY = positionY;
            HP = hP;
        }
        public void moveTo(int x, int y)
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
    }
}