using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotator1 : MonoBehaviour
{
    [SerializeField] private float _value;
    [SerializeField] private float _duration;
    private float _maxValue = 360;

    private void Update()
    {
        transform.DOLocalRotate(new Vector3(transform.rotation.x, _value, transform.rotation.z), _duration);

        _value++;

        if (_value > _maxValue)
        {
            _value = 0;
        }
    }
}
