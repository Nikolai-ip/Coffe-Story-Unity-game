using System;
using System.Collections;
using UnityEngine;

public class VisitorMoveController : MonoBehaviour
{
    [SerializeField] private float _moveDuration;
    private Transform _tr;
    public Spot BusySpot { private get; set; }

    public bool IsHaveSpot { get; set; }

    private Action VisitorCameToStand;
    private void Start()
    {
        _tr = GetComponent<Transform>();
        VisitorCameToStand += GetComponent<VisitorOrderController>().GenerateOrder;
    }
    public void StartMoveToSpot()
    {
        StartCoroutine(StartMoveToPoint(BusySpot.transform));
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