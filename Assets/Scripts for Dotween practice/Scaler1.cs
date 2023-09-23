using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scaler1 : MonoBehaviour
{
    [SerializeField] private float _targetScale;
    [SerializeField] private float _duration;

    private float _startScale = 1;

    void Update()
    {
        if (transform.localScale.x == _startScale)
        {
            transform.DOScale(_targetScale, _duration);
        }
        else if(transform.localScale.x == _targetScale)
        {
            transform.DOScale(_startScale, _duration);
        }
    }
}
