using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private int health = 1;
    private float rotationSpeed = 30f;
    private GameObject explosionEffect;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        explosionEffect = Resources.Load<GameObject>("ExplosionEffect");
    }

    public void OnServerInitialized(Vector3 linearVelocity, float angularMultiplier = 1f, float scale = 1f)
    {
        transform.localScale = Vector3.one * scale;
        rb.linearVelocity = linearVelocity;
        rb.angularVelocity = Random.onUnitSphere * rotationSpeed * angularMultiplier;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0) DestroyObject();
    }

    private void DestroyObject()
    {
        if (explosionEffect != null)

            Instantiate(explosionEffect, transform.position, Quaternion.identity);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TakeDamage(1);
        }
        Debug.Log($"Asteroid collided with {collision.gameObject.name}");
    }
}
