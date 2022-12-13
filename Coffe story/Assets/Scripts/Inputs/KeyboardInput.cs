using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]
public class KeyboardInput : InputController
{
    private Dictionary<KeyButton, KeyCode> _configurations = new Dictionary<KeyButton, KeyCode>()
    {
        {KeyButton.TakeOrder, KeyCode.Q },
        {KeyButton.UseCoffeMachine, KeyCode.F },
        {KeyButton.PourMilk, KeyCode.Z },
        {KeyButton.PourExpresso, KeyCode.X },
        {KeyButton.PourWater, KeyCode.C },
        {KeyButton.Take, KeyCode.Space },
    };
    [SerializeField]private bool _useButtonIsPressed = false;
    [SerializeField] private bool _milkButtonIsPressed = false;
    [SerializeField] private bool _expressoButtonIsPressed = false;
    [SerializeField] private bool _waterButtonIsPressed = false;
    [SerializeField] private bool _takeButtonIsPressed = false;

    private void Update()
    {
        CheckTake();
        CheckButtonIsPressed(KeyButton.UseCoffeMachine,ref _useButtonIsPressed);
        CheckButtonIsPressed(KeyButton.PourMilk,ref _milkButtonIsPressed);
        CheckButtonIsPressed(KeyButton.PourExpresso,ref _expressoButtonIsPressed);
        CheckButtonIsPressed(KeyButton.PourWater,ref _waterButtonIsPressed);
        CheckButtonIsPressed(KeyButton.Take, ref _takeButtonIsPressed);
    }
    private void CheckTake()
    {
        if (Input.GetKeyDown(_configurations[KeyButton.Take]))
        {
            
        }
    }
    private void CheckButtonIsPressed(KeyButton keyButton,ref bool buttonIsPressed)
    {
        if (Input.GetKeyDown(_configurations[keyButton]))
        {
            buttonIsPressed = true;
        }
        if (Input.GetKeyUp(_configurations[keyButton]))
        {
            buttonIsPressed = false;
        }
    }
    public override float GetX => Input.GetAxis("Horizontal");

    public override float GetY => Input.GetAxis("Vertical");

    public override bool GetUseButtonIsPressed => _useButtonIsPressed;

    public override bool IsPourMilkButtonPressed => _milkButtonIsPressed;

    public override bool IsPourExpressoButtonPressed => _expressoButtonIsPressed;

    public override bool IsPourWaterButtonPressed => _waterButtonIsPressed;

    public override bool IsTakeButtonPressed => _takeButtonIsPressed;
}