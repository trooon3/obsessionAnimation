using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MaterialColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Material _targetMaterial;
    [SerializeField] private MeshRenderer _meshRenderer;
    
    private void Start()
    {
        _meshRenderer.material.DOColor(_targetMaterial.color, _duration).SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
