using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _spenSpeed = 12f;
    private void Update()
    {
        transform.Rotate(Vector3.up, _spenSpeed * Time.deltaTime);
    }
}
