using UnityEngine;

public abstract class InputController : MonoBehaviour
{
    protected enum KeyButton
    {
        TakeOrder,
    }

    public abstract float GetX { get; }
    public abstract float GetY { get; }
}