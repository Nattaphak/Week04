public class Unit
{
    private int ratio;


    public Unit(int ratio)
    {
        this.ratio = ratio;
    }

    public int Convert(int unit)
    {
        return unit * this.ratio;
    }
}