using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    //create a public method which reduces hitpoints by the amount of damage

    bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        BroadcastMessage("OnDamageTaken");
        if (hitPoints <=0)
        {
            Die();
        }
    } 

    void Die()
    {
        if (isDead) return;

        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }

}
