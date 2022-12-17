using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _mainCharacter;
    [SerializeField] private float _dy;
    [SerializeField] private float _smooth;
    [SerializeField] private float _maxLeftBoardX;
    [SerializeField] private float _maxUpBoardY;
    private void Awake()
    {
        this.transform.position = new Vector3()
        {
            x = _mainCharacter.position.x,
            y = _mainCharacter.position.y - _dy,
            z = this.transform.position.z,
        };
    }

    private void Update()
    {
        Vector3 target = new Vector3()
        {
            x = transform.position.x,
            y = transform.position.y,
            z = transform.position.z,
        };
        if (_mainCharacter.position.x > _maxLeftBoardX)
        {
            target.x = _mainCharacter.position.x;
        }
        if (_mainCharacter.position.y < _maxUpBoardY)
        {
            target.y = _mainCharacter.position.y - _dy;
        }
        Vector3 pos = Vector3.Lerp(transform.position, target, _smooth * Time.deltaTime);
        transform.position = pos;
    }
}