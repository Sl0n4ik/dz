using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 1f;
    [SerializeField] private float _maxScaleValue = 35f;
    
    void Update()
    {
        if ( transform.localScale.x <= _maxScaleValue )
        transform.localScale += new Vector3(0.01f * _scaleSpeed, 0.01f * _scaleSpeed, 0.01f * _scaleSpeed);
    }
}
