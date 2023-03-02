using System;

class Character
{
    public readonly string name;
    public readonly int height;
    private double bodyfat;
    private double weight;
    
    public Character   (string name,
                        int height)
    {
        this.name = name;
        this.height = height;
        this.bodyfat = 0.0;
        this.weight = 0.0;
    }

    public float bodyfatData()
    {
        set
        {
            bodyfat = float(value);
        }
        get
        {
            return bodyfat;
        }
    }
    public float weightData()
    {
        set
        {
            weight = float(value);
        }
        get
        {
            return weight;
        }
    }
}