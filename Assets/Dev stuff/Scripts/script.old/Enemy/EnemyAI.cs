using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private Transform Actor;
    private Transform Core;
    private Health health;

    private NavMeshAgent agent;

    [SerializeField] private float Damage;
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float Health;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        health = GetComponent<Health>();
        health.maxHealth = Health;

        Core = GameObject.Find("Core").transform;

        agent.SetDestination(Core.position);
    }

    void Update()
    {
        Physics.IgnoreLayerCollision(8, 9);
    }
}
