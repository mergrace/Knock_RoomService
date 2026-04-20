using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100 ;
    public int currentHealth;

    public GameObject GameOverScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <=0)
        {
            GameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}
