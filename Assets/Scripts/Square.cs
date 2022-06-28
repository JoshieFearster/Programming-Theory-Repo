using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    protected override void DisplayText()
    {
        Debug.Log("I am a square");
    }
}
