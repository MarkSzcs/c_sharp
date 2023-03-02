using System;

class Fighter : Character
{
    private Character baseStats;
    private int health;
    private int attackDamage;
    private bool weightInDone;
    private bool preparationDone;
 
    public Fighter     (Character baseStats
                        int health,
                        int attackDamage,
                        double weight,
                        double bodyfat,
                        bool preparationDone)
    {
        this.baseStats = baseStats;
        this.health = health;
        this.attackDamage = attackDamage;
        IncreaseBaseStats(weight, bodyfat);
        this.weightInDone = true;
        this.preparationDone = preparationDone;

    }

    public Fighter(Character baseStats, bool preparationDone)
    {
        this.baseStats = baseStats;
        this.health = calculateHealth();
        this.attackDamage = calculateAttackDamage();
        this.weightInDone = false;
        this.preparationDone = preparationDone;
    }
    public void IncreaseBaseStats(float additionalBodyfat, float additionalWeight)
    {
        baseStats.bodyfatData += additionalBodyfat;
        baseStats.weightData += additionalWeight;
    }
    public Character GetBaseStats()
    {
        return baseStats;
    }
    public void IncreaseAttackDamage(int additionalAttackDamage)
    {
        attackDamage += additionalAttackDamage;
    }
    public int GetAttackDamage()
    {
        return attackDamage;
    }
    public void IncreaseHealth(int additionalHealth)
    {
        this.health += additionalHealth;
    }
    public int GetHealth()
    {
        return health;
    }
    public bool preparationData()
    {
        set
        {
            preparationDone = value;
        }
        get
        {
            return preparationDone;
        }
    }
    public weightInData()
    {
        set
        {
            weightInData = value;
        }
        get
        {
            return weightInDone;
        }
    }
    public bool isReady()
    {
        return weightInDone && preparationDone;
    }

    public void calculateAttackDamage()
    {
        attackDamage = Math.Floor((100 - bodyfat)/20);
    }
    public void calculateHealth()
    {
        health = Math.Floor(100 - bodyfat);
    }
}