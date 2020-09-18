using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkProtector : MonoBehaviour
{    
    Animator animator;
    GameObject currentTarget;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;
        if (otherObject.GetComponent<Attacker>())
        {
            Attack(otherObject);
        }
    }

    public void Attack(GameObject target)
    {
        animator.SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(int damage)
    {
        if (!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.TakeHit(damage);
        }
    }

    public void CheckCurrentTargetExistence()
    {
        if (currentTarget == null)
        {
            animator.SetBool("isAttacking", false);
        }
    }
}
