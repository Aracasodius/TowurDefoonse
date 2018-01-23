using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    private float currentHealth;
    public float maxHealth;

    void Start()
    {
        StartCoroutine(InitHealth());
    }

    void Update()
    {
        if (currentHealth < 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage(float damage)
    {
        currentHealth -= damage;
    }

    private IEnumerator InitHealth()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        currentHealth = maxHealth;
    }
}
