using UnityEngine;
public class MultimeterModel 
{
    private float _resistance = 1000f;
    private float _power = 400f;

    public float CalculateCurrent(float angle)
    {
        if (angle == 0f)
        {
            Debug.Log($"_ngle {angle}");
            return 0f;
        }
        else if (angle == 45f)
        {   Debug.Log($"_ngle {angle}");
            return _resistance;
        }
        else if (angle <= 135f)
        {   Debug.Log($"_ngle {angle}");
            return Mathf.Sqrt(_power / _resistance);
        }
        else if (angle ==225f)
        {   Debug.Log($"_ngle {angle}");
            return 0.01f;
        }
        else if (angle == 315f)
        {   Debug.Log($"_ngle {angle}");
            return Mathf.Sqrt(_power * _resistance);
        }
        else
        {
            return 0f;
        }
    }
}
