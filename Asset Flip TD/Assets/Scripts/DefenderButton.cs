using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    DefenderButton[] defenderButtons;
    Color notSelected;

    SpriteRenderer spriteRenderer;
    DefenderSpawner defenderSpawner;
    
    private void Awake()
    {
        defenderButtons = FindObjectsOfType<DefenderButton>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        notSelected = spriteRenderer.color;
        defenderSpawner = FindObjectOfType<DefenderSpawner>();
    }


    private void OnMouseDown()
    {
        foreach (DefenderButton defenderButton in defenderButtons)
        {
            defenderButton.spriteRenderer.color = notSelected;
        }
        spriteRenderer.color = Color.white;
        defenderSpawner.SetSelectedDefender(defenderPrefab);
    }
   
}
