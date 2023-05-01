using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ToggleSwithHighlight : MonoBehaviour
{
    public Material highlightMaterial; // Материал для подсветки

    private Material originalMaterial; // Исходный материал
    private float _toggle = 0f;
    private bool mouseOverObject = false; // Флаг, указывающий на нахождение мыши на объекте
    private float currentRotation = 0f;
    private float[] rotationPoints = { 45f, 135f, 225f, 315f, 0f };

    public event Action<float> OnToggleChanged;


    // Start is called before the first frame update
    void Start()
    {
        originalMaterial = GetComponent<Renderer>().material;
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = highlightMaterial;
        mouseOverObject = true;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = originalMaterial;
        mouseOverObject = false;
    }

    void Update()
    {
        if (mouseOverObject)
        {
            currentRotation += Input.GetAxis("Mouse ScrollWheel")  * 300f;
            currentRotation = Mathf.Repeat(currentRotation, 360f);
            float targetRotation = FindNearestRotationPoint(currentRotation);
            transform.rotation = Quaternion.Euler(0f, 0f, targetRotation);
            OnToggleChanged?.Invoke(_toggle);
        }
    }

    private float FindNearestRotationPoint(float angle)
    {
        float closestAngle = 0f;
        float smallestDifference = Mathf.Infinity;

        // Проходимся по всем точкам поворота и находим ближайшую к заданному углу
        foreach (float point in rotationPoints)
        {
            float difference = Mathf.Abs(angle - point);
            if (difference < smallestDifference)
            {
                smallestDifference = difference;
                closestAngle = point;
            }
        }
        _toggle = closestAngle;
        return closestAngle;
    }

    public float getToggle()
    { 
        return _toggle;
    }

}
