﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 100f)] [SerializeField] float speed = 10f;
    [SerializeField] int damagePoints = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Attacker>())
        {
            DealDamage(collision);
        }        
    }

    private void DealDamage(Collider2D collision)
    {
        collision.GetComponent<Health>().TakeHit(damagePoints);
        Destroy(gameObject);
    }
}
