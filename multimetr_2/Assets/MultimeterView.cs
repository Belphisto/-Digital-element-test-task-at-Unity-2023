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


    private float _angle = 0.0f;

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
        Debug.Log($"value {value}");
    }

    public void UpdateValue(float value, float angle)
    {
        int f = 0;
        if (angle == 0f)
        {
            _A.text = $"A {f.ToString("F2")}";
            _Tilda.text = $"~ {f.ToString("F2")}";
            _V.text =  $"V {f.ToString("F2")}";
            _Om.text = $"Ω {f.ToString("F2")}";
        }
        else if (angle == 45f)
        {
            _V.text = $"V {f.ToString("F2")}";
           _A.text = $"A {f.ToString("F2")}";
            _Tilda.text = $"~ {f.ToString("F2")}";
            _Om.text = $"Ω {value.ToString("F2")}";
        }
        else if (angle == 135f)
        {
            _V.text = $"V {f.ToString("F2")}";
            _A.text = $"A {value.ToString("F2")}";
            _Tilda.text = $"~ {f.ToString("F2")}";
            _Om.text = $"Ω {f.ToString("F2")}";
        }
        else if (angle == 225f)
        {
            _V.text = $"V {f.ToString("F2")}";
            _A.text = $"A {f.ToString("F2")}";
            _Tilda.text = $"~ {value.ToString("F2")}";
            _Om.text =  $"Ω {f.ToString("F2")}";
        }
        else if (angle == 315f)
        {
            _V.text = $"V {value.ToString("F2")}";
            _A.text = $"A {f.ToString("F2")}";
            _Tilda.text = $"~ {f.ToString("F2")}";
            _Om.text =  $"Ω {f.ToString("F2")}";
        }
        else
        {
            _V.text = $"V {f.ToString("F2")}";
            _A.text = $"A {f.ToString("F2")}";
            _Tilda.text = $"~ {f.ToString("F2")}";
            _Om.text =  $"Ω {f.ToString("F2")}";
        }
    }
}