using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathFX;

    public void DealDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            TriggerDeathEffect();
            Destroy(gameObject);
        }
    }

    void TriggerDeathEffect()
    {
        if (!deathFX) { return; }
        GameObject deathFXObj = Instantiate(deathFX, transform.position, Quaternion.identity);
        Destroy(deathFXObj, 1f);
    }
}
