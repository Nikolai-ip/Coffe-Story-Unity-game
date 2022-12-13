using UnityEngine;

public class InteractionChecker : MonoBehaviour
{
    private CoffeMachine _coffeMachine;
    private Player _player;
    private CameraController _cameraController;
    [SerializeField] private GameObject _fButtonUI;
    private void Start()
    {
        _coffeMachine = GetComponent<CoffeMachine>();
        _player = FindObjectOfType<Player>();
        _cameraController = FindObjectOfType<CameraController>();
        _fButtonUI.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out FloorCharacter playerTriggerPoint))
        {
            _fButtonUI.SetActive(true);
            if (_player.UseButtonIsPressed)
            {
                _cameraController.IncreaseCamera(5.5f);
                _coffeMachine.StartCooking();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out FloorCharacter playerTriggerPoint))
        {
            _cameraController.ExpandToOriginalSize();
            _coffeMachine.EndCooking();
            _fButtonUI.SetActive(false);
        }
    }
}
