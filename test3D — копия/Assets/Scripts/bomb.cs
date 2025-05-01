using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _explosionForce;
    [SerializeField] private ParticleSystem _particleSystem;


    private void Explode()
    {
        foreach (Rigidbody target in GetExplodableObjects())
        {
            target.AddExplosionForce(_explosionForce, transform.position, _explosionRadius );
        }
    }

    private void OnMouseUpAsButton()
    {
        Explode();
        Destroy(gameObject);
    }

    private List<Rigidbody> GetExplodableObjects()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, _explosionRadius);

        List<Rigidbody> barrels = new();

        foreach (Collider hit in hits)
        {
            if (hit.attachedRigidbody != null)
            {
                barrels.Add(hit.attachedRigidbody);
            }
        }

        return barrels;
    }
}
