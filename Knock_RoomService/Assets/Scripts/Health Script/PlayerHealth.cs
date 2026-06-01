using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerHealth : MonoBehaviour
{
    AudioManager audioManager;

    public int maxHealth = 100;
    public int currentHealth;
    private Animator animator;
    bool isDead = false; 

    public HealthBar healthBar;
    public GameObject gameoverpanel;
    public GameObject deathEffect;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        gameoverpanel.SetActive(false);

        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ghost"))
        {
            TakeDamage(10);
        }

        if (other.gameObject.CompareTag("Bat"))
        {
            TakeDamage(30);
        }
    }

    void TakeDamage(int damage)
    {
        if (isDead) return;
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
   
        if (currentHealth <=0)
        {
            Die();
        }
    }

    void Die()
    {
        audioManager.PlaySFX(audioManager.playerdeath);
        isDead = true;
        animator.SetTrigger("Die");

        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }
        
        gameoverpanel.SetActive(true);
        Destroy(gameObject);
        Debug.Log("Player died");
        Time.timeScale = 1f;

    }


}
