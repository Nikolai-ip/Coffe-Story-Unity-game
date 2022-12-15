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
    protected Dictionary<string, CoffeComponent> _coffeComponentKeys = new Dictionary<string, CoffeComponent>()
    {
        {"1",CoffeComponent.Milk },
        {"2",CoffeComponent.Esspresso },
        {"3",CoffeComponent.Water },
    };
    public abstract float GetX { get; }
    public abstract float GetY { get; }
    public abstract bool GetUseButtonIsPressed { get; }
}