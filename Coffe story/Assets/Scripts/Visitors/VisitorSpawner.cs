using System.Collections;
using UnityEngine;

public class VisitorSpawner : MonoBehaviour
{
    private Transform _startPosition;
    private QueueController _visitorsQueue;
    [SerializeField] private float _intervalTimeBetweenSpawn;
    [SerializeField] private GameObject _visitorPrefab;
    public float GetIntervalTimeBetweenSpawn { get => _intervalTimeBetweenSpawn; }

    private void Start()
    {
        _startPosition = GameObject.FindGameObjectWithTag("VisitorSpawnStartPosition").transform;
        _visitorsQueue = FindObjectOfType<QueueController>();
        StartCoroutine(StartVisitorSpawn());
    }

    private IEnumerator StartVisitorSpawn()
    {
        float time = 0;
        var frameTime = new WaitForSeconds(0);
        while (true)
        {
            if (time >= _intervalTimeBetweenSpawn)
            {
                CreateVisitor();
                time = 0;
            }
            time += Time.deltaTime;
            yield return frameTime;
        }
    }

    private void CreateVisitor()
    {
        var visitor = Instantiate(_visitorPrefab);
        visitor.transform.localPosition = _startPosition.position;
        _visitorsQueue.Add(visitor.GetComponent<VisitorMoveController>());
    }
}