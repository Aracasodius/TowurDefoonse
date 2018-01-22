using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    [SerializeField] private List<Transform> Enemies;
    [SerializeField] private Transform CurrentTarget;
    [Space]
    [SerializeField] private MeshCollider range;

    void Start()
    {
        if (range == null) { range = GetComponent<MeshCollider>(); }
    }

    void Update()
    {
        if (Enemies.Count != 0)
        {
            if (Enemies[0] != null) { CurrentTarget = Enemies[0]; }
            else { CurrentTarget = null; }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Enemies.Add(other.transform);
        }
    }
}
