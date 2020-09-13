using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManaDisplay : MonoBehaviour
{
    [SerializeField] int mana = 100;
    TextMeshProUGUI manaText;

    void Start()
    {
        manaText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        manaText.text = mana.ToString();
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
