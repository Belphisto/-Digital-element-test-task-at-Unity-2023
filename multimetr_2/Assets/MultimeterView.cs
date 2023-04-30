using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MultimeterView : MonoBehaviour 
{
    public event Action<float> OnAngleChanged;

    [SerializeField] private Transform _needleTransform;
    [SerializeField] private TextMeshPro _valueText;

    [SerializeField] private TextMeshProUGUI _V;
    [SerializeField] private TextMeshProUGUI _A;
    [SerializeField] private TextMeshProUGUI _Tilda;
    [SerializeField] private TextMeshProUGUI _Om;
    private MultimeterController _controller;


    public float _angle = 0.0f;

    public float Angle
    {
        get { return _angle; }
        set
        {
            _angle = value;
            _needleTransform.rotation = Quaternion.Euler(0f, 0f, _angle);

            OnAngleChanged?.Invoke(_angle);

        }
    }

    public void UpdateValue(float value)
    {
        _valueText.text = value.ToString("F2");
        _angle = value;
        Debug.Log($"value {value}");
    }


}