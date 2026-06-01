using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using static BulletType;
using static Shooting;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;
    public float maxTravelDistance = 15f;
    private int buildIndex;
    private Vector2 startPosition;

    private Rigidbody2D rb;
    private GhostsAttack ghostAttack;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * speed;

        startPosition = transform.position;
        buildIndex = SceneManager.GetActiveScene().buildIndex;

        if (buildIndex == 3)
        {
            rb.gravityScale = 0.5f;
        }
    }

    void Update()
    {
        if (Vector2.Distance(startPosition, transform.position) >= maxTravelDistance)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ghost"))
        {
            GhostsAttack enemy = collision.GetComponent<GhostsAttack>();

            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Destroy(gameObject);

            if (buildIndex != 2)
            {
                Destroy(gameObject);
            }
        }

          else if (collision.CompareTag("Vampire"))
          {
            VampireHealth vampire = collision.GetComponent<VampireHealth>();
            if (vampire != null)
            {
                Debug.Log("log"); 
                // Deals the bullet's regular low damage amount
                vampire.DamageVampire(damage);
            }
            Destroy(gameObject);
          }


          else if (collision.CompareTag("Bat"))
          {
            HomingProjectile projectile = collision.GetComponent<HomingProjectile>();
            if (projectile != null)
            {
                Debug.Log("deal dmg" + collision.gameObject.name);
                projectile.TakeDamage();
            }
            Destroy(gameObject);
          }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (buildIndex == 4 && collision.gameObject.CompareTag("Ricochet"))
        {
            Vector2 reflection = Vector2.Reflect(rb.linearVelocity, collision.contacts[0].normal);

            rb.linearVelocity = reflection.normalized * speed;

            float angle = Mathf.Atan2(reflection.y, reflection.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(0,0,angle);
        }
    }
}
