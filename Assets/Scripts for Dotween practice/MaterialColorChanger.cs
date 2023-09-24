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
    private WaitForSeconds _waitSeconds;
    
    private void Start()
    {
        _waitSeconds = new WaitForSeconds(_duration);
        StartCoroutine(ChangeScale());
    }

    private IEnumerator ChangeScale()
    {
        while (true)
        {
            _material.DOColor(_targetColor, _duration);
            yield return _waitSeconds;

            _material.DOColor(_startColor, _duration);
            yield return _waitSeconds;
        }
    }
}
