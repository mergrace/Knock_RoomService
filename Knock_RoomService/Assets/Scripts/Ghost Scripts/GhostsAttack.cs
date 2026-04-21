using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostsAttack : MonoBehaviour
{
    public int maxhealth = 100;

    public GameObject deathEffect;

    public FloatingHealthBar healthBar;

    public int currentHealth;

    void Start()
    {
        healthBar.SetMaxHealth(maxhealth);
        currentHealth = maxhealth;
}

    public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthBar.SetMaxHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnCollisioneEnter2D(Collider2D Col)
    {
        if (Col.gameObject.CompareTag("Rotten"))
        {
            TakeDamage(15);
        }
    }
}
