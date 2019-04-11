using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathFX;
    [SerializeField] float deathFXDuration = 5f;

    public void DealDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
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
