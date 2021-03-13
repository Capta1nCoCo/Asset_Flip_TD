using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelContoller : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] float delayInSeconds = 3f;
    int numberOfAttackers = 0;
    bool roundTimerActive = true;
    

    private void Start()
    {
        winLabel.SetActive(false);
    }

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
            StartCoroutine(HandleWinCondition());
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

    IEnumerator HandleWinCondition()
    {        
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(delayInSeconds);
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }
}
