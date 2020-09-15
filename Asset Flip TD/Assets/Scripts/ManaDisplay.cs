using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManaDisplay : MonoBehaviour
{
    [SerializeField] int mana = 100;
    TextMeshProUGUI manaText;

    private void Awake()
    {
        manaText = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {        
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        manaText.text = mana.ToString();
    }

    public bool HaveEnoughMana(int amount)
    {
        return mana >= amount;
    }

    public void AddMana(int amount)
    {
        mana += amount;
        UpdateDisplay();
    }

    public void SpendMana(int amount)
    {
        if (mana >= amount)
        {
            mana -= amount;
            UpdateDisplay();
        }
        else
        {
            Debug.Log("I need more mana!");
        }                
    }

}
