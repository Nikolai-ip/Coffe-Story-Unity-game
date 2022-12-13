using UnityEngine;

public class VisitorOrderController : MonoBehaviour
{
    [SerializeField]private int _foodsCount;
    private VisitorOrderView _view;
    private Food _foodOrder;
    private OrderGenerator _orderGenerator = new OrderGenerator();
    private void Start()
    {
        _view = GetComponentInChildren<VisitorOrderView>();
        _foodsCount = _view.FoodsCount;
    }
    public void GenerateOrder()
    {
        _foodOrder = _orderGenerator.GetRandom(_foodsCount);
        _view.ShowUIOrder(_foodOrder);
    }
}
