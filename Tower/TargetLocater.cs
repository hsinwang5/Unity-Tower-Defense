using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocater : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] ParticleSystem projectiles;
    [SerializeField] float range = 15f;
    Transform target;

    void Update()
    {
        FindClosestTarget();
        AimWeapon();
    }

    void FindClosestTarget()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Transform closestTarget = null;
        float maxDistance = Mathf.Infinity;

        foreach (Enemy enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position, enemy.transform.position);
            if (targetDistance < maxDistance)
            {
                closestTarget = enemy.transform;
                maxDistance = targetDistance;
            }
        }
        target = closestTarget;
    }

    void AimWeapon() 
    {
        if (target == null) {return;}
        float targetDistance = Vector3.Distance(transform.position, target.position);
        weapon.LookAt(target.position);
        if (targetDistance < range) 
        {
            Attack(true);
        }
        else 
        {
            Attack(false);
        }
    }

    void Attack(bool isActive)
    {
        ParticleSystem.EmissionModule emissionModule = projectiles.emission;
        emissionModule.enabled = isActive;
    }
}
