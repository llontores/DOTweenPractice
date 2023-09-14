using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ManipulateText : MonoBehaviour
{
    private const int _firstManipulateCommand = 1;
    private const int _secondManipulateCommand = 2;
    private const int _thirdManipulateCommand = 3;

    [SerializeField] private Text _text;
    [SerializeField] private string _changedText;
    [SerializeField] private string _addedText;
    [SerializeField] private float _duration;

    private float _counter;
    private float _elapsedTime;

    private void Start()
    {
        ChangeText();
        _counter++;
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime >= _duration)
        {
            switch (_counter)
            {
                case _firstManipulateCommand:
                    ChangeText();
                    break;

                case _secondManipulateCommand:
                    AddText();
                    break;

                case _thirdManipulateCommand:
                    ScrambleText();
                    break;
            }

            _elapsedTime = 0;
            _counter++;
        }
    }

    private void ChangeText()
    {
        _text.DOText(_changedText, _duration);
    }

    private void AddText()
    {
        _text.DOText(_addedText, _duration).SetRelative();
    }

    private void ScrambleText()
    {
        _text.DOText(_changedText, _duration, true, ScrambleMode.All);
    }
}
