using System;
using UnityEngine;

public class RaitingStarsController : MonoBehaviour
{
    [SerializeField] private int _score;

    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            CalculateYellowsStarsCount();
        }
    }

    private int _starsCount;
    [SerializeField] private int _maxRaiting;
    [SerializeField] private int _yellowsStarsCount;
    [SerializeField] public int negativeRaitingValue;
    [SerializeField] public int positiveRaitingValue;
    private StarView _view;

    private void Start()
    {
        _view = GetComponent<StarView>();
        _starsCount = _view.StarsUICount;
    }

    private void CalculateYellowsStarsCount()
    {
        int count = (int)Math.Floor((decimal)Score / _maxRaiting * 10);
        _yellowsStarsCount = count > 0 ? count : 0;
        _view.ShowStarsUI(_yellowsStarsCount);
    }
}