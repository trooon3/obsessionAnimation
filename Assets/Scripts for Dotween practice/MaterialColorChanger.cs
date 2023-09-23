using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MaterialColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private Color _startColor;
    [SerializeField] private float _duration;
    [SerializeField] private Material _material;

    private void Start()
    {
        _startColor = _material.color;
    }

    private void Update()
    {
        if (_material.color == _startColor)
        {
            _material.DOColor(_targetColor, _duration);
        }
        else if (_material.color == _targetColor)
        {
            _material.DOColor(_startColor, _duration);
        }
    }
}
