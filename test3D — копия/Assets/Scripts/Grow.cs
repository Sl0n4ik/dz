using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 1f;
    
    private void Update()
    {
        transform.localScale += new Vector3(0.01f * _scaleSpeed, 0.01f * _scaleSpeed, 0.01f * _scaleSpeed);
    }
}
