using UnityEngine;

public class InteractionChecker : MonoBehaviour
{
    private CoffeMachine _coffeMachine;
    private Player _player;
    private CameraController _cameraController;
    [SerializeField] private GameObject _fButtonUI;
    [SerializeField] private bool _coffeMachineIsUsed = false;
    [SerializeField] private float _increaseCameraValue;
    private void Start()
    {
        _coffeMachine = GetComponent<CoffeMachine>();
        _player = FindObjectOfType<Player>();
        _cameraController = FindObjectOfType<CameraController>();
        _fButtonUI.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out FloorCharacter playerTriggerPoint) && !_player.IsHoldFood)
        {
            _fButtonUI.SetActive(true);
            if (_player.UseButtonIsPressed)
            {
                _coffeMachineIsUsed = true;
                _cameraController.IncreaseCamera(_increaseCameraValue);
                _coffeMachine.StartCooking();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out FloorCharacter playerTriggerPoint))
        {
            _fButtonUI.SetActive(false);
            if (_coffeMachineIsUsed)
            {
                _cameraController.ExpandToOriginalValues();
                _coffeMachine.EndCooking();
                _coffeMachineIsUsed = false;
            }
        }
    }
}