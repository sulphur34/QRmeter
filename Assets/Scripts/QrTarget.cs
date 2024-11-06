using UnityEngine;

public class QrTarget : MonoBehaviour
{
    private Transform _qrTransform;

    public bool IsDetected { get; private set; }

    private void Start()
    {
        _qrTransform = transform;
    }

    public void OnTrackingFound()
    {
        IsDetected = true;
    }

    public void OnTrackingLost()
    {
        IsDetected = false;
    }

    public Vector3 GetPosition()
    {
        return _qrTransform.position;
    }
}