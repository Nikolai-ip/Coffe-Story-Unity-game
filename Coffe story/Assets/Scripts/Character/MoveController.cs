using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveController : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speedX;
    [SerializeField] private float _speedY;
    private InputController _inputController;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _inputController = GetComponent<InputController>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rb.velocity = new Vector3(_inputController.GetX * _speedX, _inputController.GetY * _speedY, 0);
    }
}