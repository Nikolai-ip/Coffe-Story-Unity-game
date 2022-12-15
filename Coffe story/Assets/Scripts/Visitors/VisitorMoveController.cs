using System;
using System.Collections;
using UnityEngine;

public class VisitorMoveController : MonoBehaviour
{
    [SerializeField] private float _moveDuration;
    [SerializeField] private float _destroyTime;
    private Transform _goAwayPoint;
    private Transform _tr;
    public Spot BusySpot { private get; set; }

    public bool IsHaveSpot { get; set; }

    private Action VisitorCameToStand;
    private void Start()
    {
        _tr = GetComponent<Transform>();
        VisitorCameToStand += GetComponent<VisitorOrderController>().GenerateOrder;
        _goAwayPoint = GameObject.FindGameObjectWithTag("GoAwayPoint").transform;
    }
    public void StartMoveToSpot()
    {
        StartCoroutine(StartMoveToPoint(BusySpot.transform));
    }
    public void GoAway()
    {
        BusySpot.IsBusy = false;
        StartCoroutine(StartMoveToPoint(_goAwayPoint));
        Invoke("DestroyVisitor", _destroyTime);
    }
    private void DestroyVisitor()
    {
        Destroy(gameObject);
    }
    private IEnumerator StartMoveToPoint(Transform point)
    {
        var fixedUpdateFrame = new WaitForFixedUpdate();
        float time = 0;
        Vector2 startPosition = _tr.position;
        while (true)
        {   
            Vector2 step = Vector2.Lerp(startPosition, point.position, time/_moveDuration);
            _tr.position = step;
            time += Time.deltaTime;
            if (time >= _moveDuration)
            {
                VisitorCameToStand.Invoke();
                yield break;
            }            
            yield return fixedUpdateFrame;     
        }
        
    }

}