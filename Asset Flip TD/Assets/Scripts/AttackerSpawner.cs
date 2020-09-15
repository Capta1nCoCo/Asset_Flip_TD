using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker attackerPrefab;
    [Header("Random.Range")]
    [Tooltip("In Seconds")] [SerializeField] float minSpawnDelay = 1f;
    [Tooltip("In Seconds")] [SerializeField] float maxSpawnDelay = 5f;

    bool canSpawn = true;

    IEnumerator Start()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Attacker newAttacker = Instantiate(attackerPrefab, transform.position, Quaternion.identity) as Attacker;
        newAttacker.transform.parent = transform;

    }
        
}
