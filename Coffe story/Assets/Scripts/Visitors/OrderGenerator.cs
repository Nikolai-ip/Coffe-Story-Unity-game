using System;

public class OrderGenerator
{
    public Food GetRandom(int foodsCount)
    {
        return (Food)(new Random().Next(0, foodsCount));
    }
    public Food GetCertain(int foodIndex)
    {
        return (Food)foodIndex;
    }
}