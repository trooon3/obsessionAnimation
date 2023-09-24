using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scaler1 : MonoBehaviour
{
    [SerializeField] private float _targetScale;
    [SerializeField] private float _duration;
    private WaitForSeconds _waitSeconds;
    private float _startScale = 1;

    private void Start()
    {
        _waitSeconds = new WaitForSeconds(_duration);
        StartCoroutine(ChangeScale());
    }

    private IEnumerator ChangeScale()
    {
        while (true)
        {
            transform.DOScale(_targetScale, _duration);
            yield return _waitSeconds;

            transform.DOScale(_startScale, _duration);
            yield return _waitSeconds;
        }
    }
}
