using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class QueueController : MonoBehaviour
{
    [SerializeField] private List<VisitorMoveController> _visitors = new List<VisitorMoveController>();
    [SerializeField] private List<Spot> _spots = new List<Spot>();
    private void Start()
    {
        InitSpots();
    }
    private void InitSpots()
    {
        foreach (var spot in FindObjectsOfType<Spot>())
        {
            _spots.Add(spot);
        }
        _spots.Reverse();
    }
    private void Update()
    {
        try
        {
            SetMoveSpotVisitor();
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
    private void SetMoveSpotVisitor()
    {
        Spot freeSpot = FindFreeSpot();
        foreach (var visitor in _visitors)
        {
            if (!visitor.IsHaveSpot && freeSpot != null)
            {
                visitor.BusySpot = freeSpot;
                visitor.IsHaveSpot = true;
                freeSpot.IsBusy = true;
                visitor.StartMoveToSpot();
            }
        }
        
    }
    private Spot FindFreeSpot()
    {
        for (int i = _spots.Count-1; i >= 0; i--)
        {
            if (!_spots[i].IsBusy)
                return _spots[i];
        }
        return null;
    }
    public void Add(VisitorMoveController visitor)
    {
        _visitors.Add(visitor);
    }
}
