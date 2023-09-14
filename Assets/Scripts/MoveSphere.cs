using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private float _addedDistance;
    [SerializeField] private float _duration;

    private float _target;

    private void Start()
    {
        _target = transform.position.x + _addedDistance;
        transform.DOMoveX(_target, _duration).SetLoops(-1,LoopType.Yoyo); 
    }
}
