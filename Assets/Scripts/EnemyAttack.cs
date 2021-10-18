using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 20f;

    NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        Debug.Log("Feel the fury of mighty duck!");
            target.TakeDamage(damage);
    }

}
