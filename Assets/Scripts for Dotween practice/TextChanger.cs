using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    private WaitForSeconds _waitSeconds = new WaitForSeconds(2);

    private IEnumerator ChangeText()
    {
        _text.DOText("ћен€ю текст", _duration);
        yield return _waitSeconds;

        _text.DOText(", а сейчас дополн€ю", _duration).SetRelative();
        yield return _waitSeconds;

        _text.DOText("Ќовый измененный текст", _duration, true, ScrambleMode.All);
        yield return _waitSeconds;
    }

    private void Start()
    {
        StartCoroutine(ChangeText());
    }

    
}
