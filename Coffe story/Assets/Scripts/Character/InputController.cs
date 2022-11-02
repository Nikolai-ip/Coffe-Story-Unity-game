
using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]
public class InputController : MonoBehaviour
{
    private MoveController _playerMoveController;
    private enum KeyButton
    {
        Jump,
        InvokeFire,
        InvokeWater,
        InvokeEarth,
        InvokeCombination,
    }
    
    private Dictionary<KeyButton, KeyCode> _configurations = new Dictionary<KeyButton, KeyCode>()
    {

    };
    private event Action<Vector2> _onMoveButtonPressed;

    private void Start()
    {
        _playerMoveController = GetComponent<MoveController>();
        _onMoveButtonPressed += _playerMoveController.Move;
    }
    private void FixedUpdate()
    {
        CheckMove();
    }
    private void CheckMove()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        _onMoveButtonPressed.Invoke(new Vector2(moveX,moveY));
    }
 

}
