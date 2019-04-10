using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int startingHealth = 100;
    [SerializeField] int currentHealth;
    [SerializeField] GameObject deathFX;
    [SerializeField] float deathFXDuration = 5f;

    void Start()
    {
        currentHealth = startingHealth;
    }

    public void DealDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(deathFX, transform.position, Quaternion.identity);
        Destroy(deathFX, 5f);
    }
}
