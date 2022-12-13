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
    public abstract float GetX { get; }
    public abstract float GetY { get; }
    public abstract bool GetUseButtonIsPressed { get; }
    public abstract bool IsPourMilkButtonPressed { get; }
    public abstract bool IsPourExpressoButtonPressed { get; }
    public abstract bool IsPourWaterButtonPressed { get; }
    public abstract bool IsTakeButtonPressed { get; }
}