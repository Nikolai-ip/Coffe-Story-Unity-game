using UnityEngine;

public class VisitorReactingController : MonoBehaviour
{
    private VisitorMoveController _moveController;
    private RaitingStarsController _raitingController;
    [SerializeField] private Sprite _sadSprite;
    [SerializeField] private Sprite _happySprite;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _moveController = GetComponent<VisitorMoveController>();
        _raitingController = FindObjectOfType<RaitingStarsController>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void NegativeReacting()
    {
        _raitingController.Score -= _raitingController.negativeRaitingValue;
        _spriteRenderer.sprite = _sadSprite;
        _moveController.GoAway();
    }

    public void PositiveReacting()
    {
        _raitingController.Score += _raitingController.positiveRaitingValue;
        _spriteRenderer.sprite = _happySprite;
        _moveController.GoAway();
    }
}