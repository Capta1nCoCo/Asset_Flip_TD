using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelContoller : MonoBehaviour
{
    int numberOfAttackers = 0;
    bool roundTimerActive = true;      

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        if (!roundTimerActive && numberOfAttackers <= 0)
        {
            Debug.Log("End Level Now!");
        }
    }

    public void LevelTimerFinished()
    {
        roundTimerActive = false;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
