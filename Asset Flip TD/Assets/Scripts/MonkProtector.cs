using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkProtector : MonoBehaviour
{
    [SerializeField] int damage = 25;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("isAttacking", true);
    }

}
