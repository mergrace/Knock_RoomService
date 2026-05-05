using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    public int health = 5;

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
