using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION AND INHERITANCE
public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    [field: SerializeField]
    public Color ShapeColor { get; set; }

    private void Awake()
    {
        SetColor();
    }

    private void SetColor()
    {
        Renderer mr = GetComponent<Renderer>();

        mr.material.color = ShapeColor;
    }

    // POLYMORPHISM
    protected abstract void DisplayText();

    private void OnMouseDown()
    {
        DisplayText();
    }
}
