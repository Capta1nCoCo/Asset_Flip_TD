using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    ManaDisplay manaDisplay;

    private void Awake()
    {
        manaDisplay = FindObjectOfType<ManaDisplay>();
    }

    private void OnMouseDown()
    {
        AttemptToPlaceDefenderAt(GetSquareClicked());
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        int defenderCost = defender.GetManaCost();
        if (manaDisplay.HaveEnoughMana(defenderCost))
        {
            SpawnDefender(gridPos);
            manaDisplay.SpendMana(defenderCost);
        }
            
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);         
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 roundedWorldPos)
    {
        if (defender == null)
        {
            Debug.Log("Please select a defender you want to build here!");
            return;
        }
        Defender newDefender = Instantiate(defender, roundedWorldPos, Quaternion.identity) as Defender;
    }
}
