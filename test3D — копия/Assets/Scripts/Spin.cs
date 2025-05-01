using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _spenSpeed = 12f;
    void Update()
    {
        transform.Rotate(Vector3.up, _spenSpeed * Time.deltaTime);
    }
}
