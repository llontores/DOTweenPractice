using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpeenCube : MonoBehaviour
{
    [SerializeField] private float _target;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DORotate(new Vector3(0, 0, _target), _duration).SetLoops(-1,LoopType.Yoyo);
    }
}
