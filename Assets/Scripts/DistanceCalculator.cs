using System;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    [SerializeField] private QrTarget _firstQrTarget;
    [SerializeField] private QrTarget _secondQrTarget;

    public DistanceData DistanceData { get; private set; }

    private void Update()
    {
        if (!_firstQrTarget.IsDetected || !_secondQrTarget.IsDetected)
        {
            DistanceData = null;
            return;
        }

        var firstTargetPosition = _firstQrTarget.GetPosition();
        var secondTargetPosition = _secondQrTarget.GetPosition();
        float distance = Vector3.Distance(_firstQrTarget.GetPosition(), _secondQrTarget.GetPosition());

        DistanceData = new DistanceData()
        {
            FirstTargetPosition = firstTargetPosition,
            SecondTargetPosition = secondTargetPosition,
            Distance = distance
        };
    }
}