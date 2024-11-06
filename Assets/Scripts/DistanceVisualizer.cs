using TMPro;
using UnityEngine;

public class DistanceVisualizer :MonoBehaviour
{
    [SerializeField] private DistanceCalculator _distanceCalculator;
    [SerializeField] private LineRenderer _lineRenderer;
    [SerializeField] private TextMeshProUGUI _distanceText;

    private Transform _textTransform;

    private void Awake()
    {
        _textTransform = _distanceCalculator.transform;
    }

    private void Update()
    {
        if (_distanceCalculator.DistanceData == null)
        {
            _lineRenderer.enabled = false;
            _distanceText.enabled = false;
            return;
        }

        _lineRenderer.enabled = true;
        _distanceText.enabled = true;
        var distanceData = _distanceCalculator.DistanceData;
        _lineRenderer.SetPosition(0, distanceData.FirstTargetPosition);
        _lineRenderer.SetPosition(1, distanceData.SecondTargetPosition);
        Vector3 midpoint = (distanceData.FirstTargetPosition + distanceData.SecondTargetPosition) / 2;
        _distanceText.text = $"{distanceData.Distance:F2} м";
        _textTransform.position = midpoint + Vector3.up * 0.05f;
    }
}