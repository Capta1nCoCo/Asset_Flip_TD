﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int healthPoints = 100;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeHit(int damage)
    {
        healthPoints -= damage;
        if (healthPoints <= 0)
        {
            Die();
        }
        else
        {
            animator.SetTrigger("TakeHit");
        }
    }

    private void Die()
    {
        animator.SetTrigger("Death");
        Destroy(gameObject, 1f);
    }
}
