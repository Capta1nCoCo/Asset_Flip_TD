using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int healthPoints = 100;

    Animator animator;

    private void Awake()
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
        Destroy(GetComponent<BoxCollider2D>());
        Destroy(gameObject, 1f);
    }
}
