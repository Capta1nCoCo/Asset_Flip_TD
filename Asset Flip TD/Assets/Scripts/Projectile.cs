using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 100f)] [SerializeField] float speed = 10f;
    [SerializeField] int damagePoints = 25;

    [Header("Visual Modifiers")]
    [SerializeField] bool isExplosive;
    [SerializeField] ParticleSystem explosionVFX;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var attacker = collision.GetComponent<Attacker>();
        var health = collision.GetComponent<Health>();

        if (attacker && health)
        {
            DealDamage(health);
        }        
    }

    private void DealDamage(Health health)
    {
        health.TakeHit(damagePoints);
        Destroy(gameObject);
        if (isExplosive)
        {
            Instantiate(explosionVFX, transform.position, Quaternion.identity);
        }
    }
}
