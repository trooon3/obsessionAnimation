using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private Color _startColor;
    [SerializeField] private float _duration;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    private WaitForSeconds _waitSeconds;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startColor = _spriteRenderer.color;
        _waitSeconds = new WaitForSeconds(_duration);
        StartCoroutine(ChangeScale());
    }

    private IEnumerator ChangeScale()
    {
        while (true)
        {
            _spriteRenderer.DOColor(_targetColor, _duration);
            yield return _waitSeconds;

            _spriteRenderer.DOColor(_startColor, _duration);
            yield return _waitSeconds;
        }
    }
}
