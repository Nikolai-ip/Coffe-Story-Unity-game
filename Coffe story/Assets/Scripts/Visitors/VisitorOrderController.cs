using System;
using UnityEngine;

public class VisitorOrderController : MonoBehaviour
{
    private int _foodsCount = Enum.GetNames(typeof(FoodType)).Length - 1;
    private VisitorOrderView _view;
    private FoodType _foodOrder;
    private OrderGenerator _orderGenerator = new OrderGenerator();
    private FoodTray _foodTray;

    private void Start()
    {
        _view = GetComponentInChildren<VisitorOrderView>();
        _foodsCount = _view.FoodsCount;
    }

    public void GenerateOrder()
    {
        _foodOrder = _orderGenerator.GetRandom(_foodsCount);
        _view.ShowUIOrder(_foodOrder);
        FindFoodTray();
    }

    private void FindFoodTray()
    {
        var hit = Physics2D.Raycast(transform.position, Vector2.up, 10, LayerMask.GetMask("FoodTray"));
        if (hit.collider != null)
        {
            if (hit.collider.TryGetComponent(out FoodTray foodTray))
            {
                _foodTray = foodTray;
                _foodTray.ExpectedOrder = _foodOrder;
                _foodTray.VisitorReactingController = GetComponent<VisitorReactingController>();
            }
        }
    }
}