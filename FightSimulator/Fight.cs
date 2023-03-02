using System;

class Fight
{
    private string winnerName;
    private readonly int numberOfRounds;
    private readonly int numberOfDaysToPrepare;
    private readonly Fighter defender;
    private readonly Fighter challenger;
    private readonly Random seed = new Random(); //generates a seed
    private readonly int rng = seed.Next(101); //generates an int from 0 to 100
    private bool weightInDone;
    private bool preparationDone;

    public Fight(int numberOfRounds, int numberOfDaysToPrepare, Fighter defender, Fighter challenger)
    {
        this.numberOfRounds = numberOfRounds;
        this.numberOfDaysToPrepare = numberOfDaysToPrepare;
        this.defender = defender;
        this.challenger = challenger;
    }
    public void Preparation()
    {
        if(rng > 65)
        {
            attackDamage+=2;
            health += 5 + Round(0,5 * rng);
        }
        else if(rng > 5 && rng <= 65){
            attackDamage += 1;
            health = 5;
        }
        else if(rng <= 5){
            attackDamage += -2;
        }
        isPrepared = true;
    }
    public void Round()
    {

    }
    public void AnnounceWinner()
    {

    }
    public void AddHomeAdvantage(Fighter player){

    }
    private boolean IsThereAWinner()
    {

    }
}