using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeScale : MonoBehaviour
{
    [SerializeField] private float _scaleMultiplier;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_scaleMultiplier, _duration).SetLoops(-1,LoopType.Yoyo);
    }
}
