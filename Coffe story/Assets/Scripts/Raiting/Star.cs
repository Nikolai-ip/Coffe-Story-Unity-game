using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private Sprite _emptyStar;
    [SerializeField] private Sprite _yellowStar;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetYellowStar()
    {
        _spriteRenderer.sprite = _yellowStar;
    }

    public void SetEmptyStar()
    {
        _spriteRenderer.sprite = _emptyStar;
    }
}