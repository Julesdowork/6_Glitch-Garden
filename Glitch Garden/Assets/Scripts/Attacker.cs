using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float currentSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile")) {
            // Debug.Log("Trigger");
            Health health = GetComponent<Health>();
            if (health) {
                health.DealDamage(other.GetComponent<Projectile>().GetDamage());
            }

            Destroy(other.gameObject);
        }
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }
}
