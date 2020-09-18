using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range (0f, 5f)] [SerializeField] float currentSpeed = 1f;
    GameObject currentTarget;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);        
    }    

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }
    
    public void Attack(GameObject target)
    {
        animator.SetBool("isAttacking", true);
        currentTarget = target;        
    }
    
    public void StrikeCurrentTarget(int damage)
    {
        if(!currentTarget) { return; }        
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
