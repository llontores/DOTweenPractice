using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(_targetColor, _duration).SetLoops(-1,LoopType.Yoyo);
    }
}
