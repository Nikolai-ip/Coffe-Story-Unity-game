using UnityEngine;

public class FoodTrayCollisionsController : MonoBehaviour
{
    [SerializeField] private Transform _foodPoint;
    [SerializeField] private float _timeToDestroyFood;
    [SerializeField] private GameObject _fButton;
    private FoodTray _foodTray;

    private Player _player;
    private InputController _playerInput;

    private void Start()
    {
        _foodTray = GetComponent<FoodTray>();
        _fButton.SetActive(false);
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
            if (_player.IsHoldFood)
            {
                _fButton.SetActive(true);
                if (_playerInput.GetUseButtonIsPressed)
                {
                    _player.IsHoldFood = false;
                    _fButton.SetActive(false);
                    PutFoodOnFoodPoint();
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_player != null)
            if (_player.IsHoldFood)
                _fButton.SetActive(false);
    }

    private void PutFoodOnFoodPoint()
    {
        var food = GameObject.FindGameObjectWithTag("TakePointPlayer").GetComponentInChildren<Food>();
        if (food != null)
        {
            food.transform.SetParent(_foodPoint);
            food.transform.localPosition = new Vector3();
            food.GetComponent<SpriteRenderer>().sortingLayerName = "Order";
            _foodTray.CookedOrder = food.FoodType;
            _foodTray.CheckEqualFoods();
            food.Destroy(timeToDestroyFood: 2);
        }
    }
}