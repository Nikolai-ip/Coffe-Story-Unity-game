using System.Collections;
using UnityEngine;

public class FoodTrayCollisionsController : MonoBehaviour
{
    [SerializeField] private Transform _foodPoint;
    [SerializeField] private float _timeToDestroyFood;
    private FoodTray _foodTray;

    private Player _player;
    private InputController _playerInput;
    private void Start()
    {
        _foodTray = GetComponent<FoodTray>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _player = player;
            _playerInput = player.GetComponent<InputController>();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            if (_playerInput.GetUseButtonIsPressed && _player.IsHoldFood)
            {
                PutFoodOnFoodPoint();
            }
        }
    }

    private void PutFoodOnFoodPoint()
    {
        var food = GameObject.FindGameObjectWithTag("TakePointPlayer").GetComponentInChildren<Food>();
        if (food != null)
        {
            food.transform.SetParent(_foodPoint);
            food.transform.localPosition = new Vector3();
            food.GetComponent<SpriteRenderer>().sortingLayerName = "Order";
            Debug.Log(food.FoodType);
            _foodTray.CookedOrder = food.FoodType;
            _foodTray.CheckEqualFoods();
            food.Destroy(2);

        }
    }

 
}