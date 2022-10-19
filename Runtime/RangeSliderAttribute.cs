using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeSliderAttribute : PropertyAttribute
{
    public float min;
    public float max;

    public RangeSliderAttribute(float _min, float _max)
    {
        min = _min;
        max = _max;

    }
    
}
