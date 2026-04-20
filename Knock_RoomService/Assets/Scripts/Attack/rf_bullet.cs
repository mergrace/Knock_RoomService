using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rf_bullet : MonoBehaviour
{  
     public float speed = 20f;
     public int damage = 15;
     public Rigidbody2D rb;

    //using this for initialization

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      rb.linearVelocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        GhostsAttack Ghosts = hitInfo.GetComponent<GhostsAttack>();
        if (Ghosts != null )
        {
            Ghosts.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
