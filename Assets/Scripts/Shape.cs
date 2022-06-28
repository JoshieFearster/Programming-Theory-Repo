using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION AND INHERITANCE
public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public Color shapeColor { get; set; }

    // POLYMORPHISM
    protected abstract void DisplayText();

    private void OnMouseDown()
    {
        DisplayText();
    }
}
