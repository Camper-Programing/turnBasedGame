public class creature
{
    public int positionx { get; set; }
    public int positiony { get; set; }
    public int HP { get; set; }

    public creature(int positionx, int positiony, int hP)
    {
        this.positionx = positionx;
        this.positiony = positiony;
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