using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    
    private void Start()
    {
        _spriteRenderer.DOColor(_targetColor, _duration).SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
