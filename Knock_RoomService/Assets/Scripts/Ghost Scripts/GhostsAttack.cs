using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostsAttack : MonoBehaviour
{
    public enum EnemyType { Ghost, Ghoul, Vampire }
    public EnemyType enemyType;
    [SerializeField]private AudioManager audioManager;

    private void Awake()
    {
        if (!audioManager)
        {
            if(GameObject.FindGameObjectWithTag("Audio")  != null)
            {
                audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
            }
            else
            {
                Debug.Log("No Audio Object");
            }

           
        }
       
    }

    public int maxhealth = 100;

    public GameObject deathEffect;

    public FloatingHealthBar healthBar;

    public int currentHealth;

    void Start()
    {
        currentHealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);

        if (audioManager)
        {
            if (enemyType == EnemyType.Ghost) 
            {
                audioManager.PlaySFX(audioManager.ghostdeath);
                Destroy(gameObject);
            }
            else if(enemyType == EnemyType.Ghoul)
            {
                audioManager.PlaySFX(audioManager.ghouldeath );
                Destroy(gameObject);
            }
            else if (enemyType == EnemyType.Vampire)
            {
                audioManager.PlaySFX(audioManager.vampiredeath);
                Destroy(gameObject);
            }
            
        }


            

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            audioManager.PlaySFX(audioManager.ghostdeath);
        }
    }

}


 
       