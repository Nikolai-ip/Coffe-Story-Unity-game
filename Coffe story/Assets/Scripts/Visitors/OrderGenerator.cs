using System;

public class OrderGenerator
{
    public FoodType GetRandom(int foodsCount)
    {
        return (FoodType)(new Random().Next(0, foodsCount));
    }

    public FoodType GetCertain(int foodIndex)
    {
        return (FoodType)foodIndex;
    }
}