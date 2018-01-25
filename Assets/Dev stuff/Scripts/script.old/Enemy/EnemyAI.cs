using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private Transform Actor;
    [SerializeField] private Transform Target;
    private Health health;

    private NavMeshAgent agent;

    [SerializeField] private float Damage;
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float Health;

    void Start()
    {
        if (Actor == null) { Actor = GetComponent<Transform>(); }

        agent = GetComponent<NavMeshAgent>();
        health = GetComponent<Health>();
        health.maxHealth = Health;

        

        
    }

    void Update()
    {
        if (Target == null) { Target = GameObject.Find("Core").transform; }

        agent.SetDestination(Target.position);
        Physics.IgnoreLayerCollision(9, 9);
        Physics.IgnoreLayerCollision(9, 10);
    }
}
