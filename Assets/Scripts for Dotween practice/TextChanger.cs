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
   
    private void Start()
    {
        DOTween.Sequence()
            .Append(_text.DOText("ћен€ю текст", _duration))
            .Append(_text.DOText(", а сейчас дополн€ю", _duration).SetRelative())
            .Append(_text.DOText("Ќовый измененный текст", _duration, true, ScrambleMode.All)).SetLoops(-1, LoopType.Restart);
    }
}
