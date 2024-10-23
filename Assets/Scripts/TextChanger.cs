using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;
    [SerializeField] private Color _color = Color.green;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;
    [SerializeField] private string _replacingText;
    [SerializeField] private string _expandingText;
    [SerializeField] private string _hackingText;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.AppendInterval(_delay);
        sequence.Append(_text.DOText(_replacingText, _duration));
        sequence.AppendInterval(_delay);
        sequence.Append(_text.DOText(_expandingText, _duration)
                .SetRelative());
        sequence.AppendInterval(_delay);
        sequence.Append(_text.DOColor(_color, _duration));
        sequence.Append(_text.DOText(_hackingText, _duration, true, ScrambleMode.All));
        sequence.AppendInterval(_delay);
        sequence.SetLoops(-1, _loopType);
    }
}