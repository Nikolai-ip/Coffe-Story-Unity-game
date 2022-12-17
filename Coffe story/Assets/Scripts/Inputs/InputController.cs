using Assets.Scripts.Food.Coffe_Machine;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputController : MonoBehaviour
{
    protected enum KeyButton
    {
        TakeOrder,
        UseCoffeMachine,
        PourMilk,
        PourExpresso,
        PourWater,
        Take,
    }

    protected Dictionary<string, CoffeComponentType> _coffeComponentKeys = new Dictionary<string, CoffeComponentType>()
    {
        {"1",CoffeComponentType.Milk },
        {"2",CoffeComponentType.Esspresso },
        {"3",CoffeComponentType.Water },
    };

    public abstract float GetX { get; }
    public abstract float GetY { get; }
    public abstract bool GetUseButtonIsPressed { get; }
}