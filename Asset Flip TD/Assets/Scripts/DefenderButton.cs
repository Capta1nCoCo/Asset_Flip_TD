using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{    
    DefenderButton[] defenderButtons;
    Color notSelected;

    SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        defenderButtons = FindObjectsOfType<DefenderButton>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        notSelected = spriteRenderer.color;        
    }


    private void OnMouseDown()
    {
        foreach (DefenderButton defenderButton in defenderButtons)
        {
            defenderButton.spriteRenderer.color = notSelected;
        }
        spriteRenderer.color = Color.white;
    }
   
}
