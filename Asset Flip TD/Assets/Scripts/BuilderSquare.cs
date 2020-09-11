using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderSquare : MonoBehaviour
{
    [SerializeField] GameObject defenderPrefab;

    float yOffset = 0.13f; 

    bool isFree = true;

    private void OnMouseDown()
    {
        BuildDefender();
    }

    private void BuildDefender()
    {
        if (isFree)
        {
            Vector2 addOffset = new Vector2(transform.position.x, transform.position.y + yOffset);
            GameObject newDefender = Instantiate(defenderPrefab, addOffset, Quaternion.identity) as GameObject;
            isFree = false;
        }
        else
        {
            Debug.Log("You can't build there!");
        }
    }
}
