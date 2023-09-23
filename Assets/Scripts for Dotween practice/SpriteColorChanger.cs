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

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startColor = _spriteRenderer.color;
    }

    private void Update()
    {
        if (_spriteRenderer.color == _startColor)
        {
            _spriteRenderer.DOColor(_targetColor, _duration);
        }
        else if (_spriteRenderer.color == _targetColor)
        {
            _spriteRenderer.DOColor(_startColor, _duration);
        }
    }
}
