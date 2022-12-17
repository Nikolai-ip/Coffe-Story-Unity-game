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

    private bool _useButtonIsPressed;

    private CoffeMachine _coffeMachine;

    private void Start()
    {
        _coffeMachine = FindObjectOfType<CoffeMachine>();
    }

    private void Update()
    {
        CheckTake();
        CheckUseButtonIsPressed(KeyButton.UseCoffeMachine);
        CheckPourComponentsButtonsIsPressed();
    }

    private void CheckPourComponentsButtonsIsPressed()
    {
        if (ComponentsButtonsIsPressed())
        {
            _coffeMachine.PourCoffeComponent(_coffeComponentKeys[Input.inputString]);
        }
    }

    private bool ComponentsButtonsIsPressed() => _coffeComponentKeys.ContainsKey(Input.inputString);

    private void CheckTake()
    {
        if (Input.GetKeyDown(_configurations[KeyButton.Take]))
        {
            _coffeMachine.CreateCoffe();
        }
    }

    private void CheckUseButtonIsPressed(KeyButton keyButton)
    {
        if (Input.GetKeyDown(_configurations[keyButton]))
        {
            _useButtonIsPressed = true;
        }
        if (Input.GetKeyUp(_configurations[keyButton]))
        {
            _useButtonIsPressed = false;
        }
    }

    public override float GetX => Input.GetAxis("Horizontal");

    public override float GetY => Input.GetAxis("Vertical");

    public override bool GetUseButtonIsPressed => _useButtonIsPressed;
}