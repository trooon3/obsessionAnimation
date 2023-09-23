using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mover1 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _duration;
    [SerializeField] private Vector3[] _waypoints;

    private void Start()
    {
        Tween tween = transform.DOPath(_waypoints, _duration, PathType.CatmullRom).SetOptions(true);

        tween.SetEase(Ease.Linear).SetLoops(-1);
    }
}
