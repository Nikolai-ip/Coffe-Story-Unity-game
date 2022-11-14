using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]
public class KeyboardInput : InputController
{
    private Dictionary<KeyButton, KeyCode> _configurations = new Dictionary<KeyButton, KeyCode>()
    {
        {KeyButton.TakeOrder, KeyCode.Space }
    };

    public override float GetX => Input.GetAxis("Horizontal");

    public override float GetY => Input.GetAxis("Vertical");
}