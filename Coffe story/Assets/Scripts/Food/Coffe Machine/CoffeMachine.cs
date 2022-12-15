using Assets.Scripts.Food.Coffe_Machine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeMachine : MonoBehaviour
{
    private CoffeMachineWindow _window;
    private bool _coffeMachinIsUsing = false;
    private CoffeComponents _coffeComponents = new CoffeComponents();
    [SerializeField] private GameObject _coffePrefab;
    [SerializeField] private Transform _createCoffePoint;
    [SerializeField] private GameObject _cupOfCoffePrefab;

    private void Start()
    {
        _window = GetComponent<CoffeMachineWindow>();
    }
    public void PourCoffeComponent(CoffeComponent component)
    {
        if (_coffeMachinIsUsing)
        {
            _coffeComponents.Add(component);
            _window.SetPourAnimation(component);
        }

    }
    public void CreateCoffe()
    {
        try
        {
            TryToCreateCoffe();
        }
        catch (Exception e)
        {
            Debug.LogError(e);
        }

    }
    private void TryToCreateCoffe()
    {
        if (_coffeMachinIsUsing)
        {
            var coffe = Instantiate(_coffePrefab);
            coffe.GetComponent<Coffe>().PourAllComponents(_coffeComponents);
            _coffeComponents.Clear();
            EndCooking();
        }
    }

    public void StartCooking()
    {
        _coffeMachinIsUsing = true;
        _window.AppearenceCoffeMachineWindow();
    }
    public void EndCooking()
    {
        if (_coffeMachinIsUsing)
        {
            _window.CloseCoffeMachineWindow();
        }
        _coffeMachinIsUsing = false;
    }
   
}
