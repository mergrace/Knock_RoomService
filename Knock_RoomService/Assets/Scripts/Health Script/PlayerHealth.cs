using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public GameObject gameoverpanel;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        gameoverpanel.SetActive(false);

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
    }

    void TakeDamage(int damage)
    {
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

        gameoverpanel.SetActive(true);
        Debug.Log("Player died");
        //Time.timeScale = 1f;

    }


}
