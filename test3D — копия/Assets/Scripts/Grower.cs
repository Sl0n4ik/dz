using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 1f;

    private void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * _scaleSpeed;
    }
}
