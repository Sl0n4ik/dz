using UnityEngine;

public class MoverForvard : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
   
    private void Update()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime, Space.Self);
    }
}
