using System;
using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera _camera;
    private CameraFollow _cameraFollow;
    [SerializeField] private float _smooth;
    private float _originalSize;
    private void Start()
    {
        _camera = GetComponent<Camera>();
        _originalSize = _camera.orthographicSize;
        _cameraFollow = GetComponent<CameraFollow>();
    }

    public void IncreaseCamera(float size)
    {
        try
        {
            _cameraFollow.isFollowForPlayer = false;
            StartCoroutine(Increase(size));

        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }
    private IEnumerator Increase(float size)
    {
        float time = 0;
        while (_camera.orthographicSize > size)
        {
            time += Time.deltaTime;
            _camera.orthographicSize -= time / _smooth;
            yield return null;
        }
    }

    public void ExpandToOriginalValues()
    {
        try
        {
            _cameraFollow.isFollowForPlayer = true;
            StartCoroutine(Expand());

        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }
    private IEnumerator Expand()
    {
        float time = 0;
        while (_camera.orthographicSize < _originalSize)
        {
            time += Time.deltaTime;
            _camera.orthographicSize += time / _smooth;
            yield return null;
        }
    }
}