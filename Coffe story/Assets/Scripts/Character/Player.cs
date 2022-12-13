using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool UseButtonIsPressed { get; private set; }
    private InputController _inputController;

    private void Start()
    {
        _inputController = GetComponent<InputController>();
    }
    private void Update()
    {
        UseButtonIsPressed = _inputController.GetUseButtonIsPressed;
    }
}
