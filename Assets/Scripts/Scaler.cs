using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleVector;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_scaleVector, _duration)
                 .SetLoops(-1, _loopType)
                 .SetEase(Ease.InOutExpo);
    }
}