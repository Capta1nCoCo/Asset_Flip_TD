using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinRogue : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;
        if (otherObject.GetComponent<Shooter>())
        {
            Assasinate(otherObject);
        }
        else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }

    private void Assasinate(GameObject shooter)
    {
        GetComponent<Animator>().SetTrigger("Assasinate");
        Destroy(shooter, 1f);
        //TODO add blood explosion particles
    }
}
