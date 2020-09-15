using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int manaCost = 100;
    
    [Header("Mana Angel Properties")]
    [Tooltip("Per Second")] [SerializeField] int manaProduction = 10;
    [SerializeField] ParticleSystem manaVFX;    

    ManaDisplay manaDisplay;

    private void Awake()
    {
        manaDisplay = FindObjectOfType<ManaDisplay>();
    }

    public int GetManaCost() { return manaCost; }

    //Mana Angel's Animation Effect!
    public void ProduceMana()
    {
        Instantiate(manaVFX, transform.position, Quaternion.identity);
        manaDisplay.AddMana(manaProduction);
    }
}
