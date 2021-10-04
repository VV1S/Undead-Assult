using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 10f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    float Damage()
    {
        return damage;
    }

    private void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            Debug.Log("I hit this thing: " + hit.transform.name);
            //TODO: add some hit effect for visual players
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;
            target.TakeDamage(damage);
            // call a method on EnemyHealth that decreases the enemy's health
        }
        else
        {
            return;
        }
    }

}
