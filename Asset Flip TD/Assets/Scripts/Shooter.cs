using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform projectileOriginPoint;

    public void Fire()
    {
        Instantiate(projectilePrefab, projectileOriginPoint.position, Quaternion.identity);
    }
}
