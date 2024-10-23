using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;
    [SerializeField] private float _duration;
    
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        _meshRenderer.material.DOColor(_color, _duration)
                              .SetLoops(-1, _loopType)
                              .SetEase(Ease.InOutBounce);
    }
}