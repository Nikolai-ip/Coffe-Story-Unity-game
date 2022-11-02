using Unity.Mathematics;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
[RequireComponent(typeof(AnimatorController))]
public class MoveController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private AnimatorController _animations;
    [SerializeField] private float _speedX;
    [SerializeField] private float _speedY;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();  
        _animations = GetComponent<AnimatorController>();
    }

    public void Move(Vector2 move)
    {
        _rb.velocity = new Vector3(move.x * _speedX, move.y* _speedY, 0);
    }
}
