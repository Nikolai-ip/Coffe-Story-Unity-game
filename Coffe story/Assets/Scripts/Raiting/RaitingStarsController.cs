using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaitingStarsController : MonoBehaviour
{
    public int Score { get; private set; }
    [SerializeField]private int _starsCount;
    private void Start()
    {
        _starsCount = GetComponentsInChildren<Transform>().Length - 1;
    }
}
