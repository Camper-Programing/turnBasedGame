public class creature
{
    public int positionX { get; private set; }
    public int positionY { get; private set; }
    public int HP { get; private set; }

    public creature(int positionX, int positionY, int hP)
    {
        positionX = positionX;
        positionY = positionY;
        HP = hP;
    }
    public void ReveiveHit(int damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            //implément observer later
        }
    }
    public void hit(creature target, int damage)
    {
        target.ReveiveHit(damage);
    }
}