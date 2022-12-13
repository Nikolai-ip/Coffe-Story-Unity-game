using System.Collections.Generic;
using UnityEngine;

public class VisitorOrderView : MonoBehaviour
{
    [SerializeField] private List<GameObject> _orderTablePrefabs= new List<GameObject>();
    private Dictionary<Food, GameObject> _order = new Dictionary<Food, GameObject>();
    public int FoodsCount
    {
        get { return _orderTablePrefabs.Count; }
    }
    private void Awake()
    {
        InitializeOrderDictionaty();
    }
    private void InitializeOrderDictionaty()
    {
        for (int i = 0; i < _orderTablePrefabs.Count; i++)
        {
            _order.Add((Food)i, _orderTablePrefabs[i]);
        } 
    }
    public void ShowUIOrder(Food food)
    {
        InstantiateOrderTable(_order[food]);
    }
    private void InstantiateOrderTable(GameObject orderTablePrefab)
    {
        var orderTable = Instantiate(orderTablePrefab);
        orderTable.transform.localPosition = transform.position;
        orderTable.transform.SetParent(transform);
    }
}
