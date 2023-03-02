using System;

class RandomEvent
{
    private Fight fight;
    private Random seed;

    public RandomEvent(Fight fight)
    {   
        this.fight = fight;
        this.seed = new Random();
    }
    private void PreparationRng(Fighter fighter)
    {
            int days = fight.numberOfDaysToPrepare;
            Double maxWeightGain = (0.5 * days);
            Double actualWeightGain = seed.NextDouble() * maxWeightGain;
            Double fighterAdditionalWeight = seed.NextDouble() * maxWeightGain; //since the interval is between 0 and 
                                                                                 //max i dont need to subtract the min
            Double fighterAdditionalBodyfat = seed.NextDouble() * ((additionalWeight/fighter.GetBaseStats().weightData) * 100);
            
            //based on the "weight distribution calculate the rng"
            int fighterRng = Math.Floor((actualWeightGain / maxWeightGain) * 100);
            
            fighter.IncreaseBaseStats(additionalWeight, additionalBodyfat);
            fighter.calculateAttackDamage;
            fighter.calculateHealth;
    }

    public void EventWeightIn()
    {
        this.seed = new Random();
        if(fight.defender.weightInData == false && fight.challenger.weightInData == false)
        {
            //needs to be done, random weight and bodyfat generation based on some logic
            //instant win condition in 2-5% of the time if the oponent is bigger 
            //else the defender should get like + 1-2 attack damage
        }

        public void Preparation()
        {
            this.seed = new Random();
            if(fight.defender.preparationData == false && fight.challenger.preparationData == false)
            {
                PreparationRng(fight.defender);
                PreparationRng(fight.challenger);
            }
        }
    }
}