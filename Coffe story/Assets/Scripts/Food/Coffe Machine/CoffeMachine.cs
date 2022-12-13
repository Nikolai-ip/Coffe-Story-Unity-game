using Assets.Scripts.Food.Coffe_Machine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeMachine : MonoBehaviour
{
    private CoffeMachineWindow _window;
    private InputController _inputController;
    private bool _coffeMachinIsUsing = false;
    private CoffeList _coffeComponentsList = new CoffeList();
    [SerializeField] private GameObject _coffePrefab;
    [SerializeField] private Transform _createCoffePoint;

    private void Start()
    {
        _window = GetComponent<CoffeMachineWindow>();
        _inputController = FindObjectOfType<InputController>();
    }
    private void Update()
    {
        if (_coffeMachinIsUsing)
        {
            Cooking();
        }
    }
    private void Cooking()
    {
        if (_inputController.IsPourMilkButtonPressed)
        {
            _coffeComponentsList.Add(CoffeComponent.Milk);
            _window.SetPourMilkAnimation();
        }
        if (_inputController.IsPourExpressoButtonPressed)
        {
            _coffeComponentsList.Add(CoffeComponent.Expresso);
            _window.SetPourExpressoAnimation();
        }
        if (_inputController.IsPourWaterButtonPressed)
        {
            _coffeComponentsList.Add(CoffeComponent.Water);
            _window.SetPourWaterAnimation();
        }
        
    }
    public void CreateCoffe()
    {
    }

    public void StartCooking()
    {
        _coffeMachinIsUsing = true;
        _window.AppearenceCoffeMachineWindow();
    }
    public void EndCooking()
    {
        _coffeMachinIsUsing = false;
        _window.CloseCoffeMachineWindow();
    }
   
}
