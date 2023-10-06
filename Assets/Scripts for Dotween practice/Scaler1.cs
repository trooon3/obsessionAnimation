using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scaler1 : MonoBehaviour
{
    [SerializeField] private float _targetScale;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_targetScale, _duration).SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
