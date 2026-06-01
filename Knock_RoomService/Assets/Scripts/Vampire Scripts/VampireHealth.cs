using System.Collections;
using UnityEngine;

public class VampireHealth : MonoBehaviour
{
    public int maxHealth = 250;
    private int currentHealth;
    public GameObject deathEffect;

    [Header("UI")]
    public FloatingHealthBar healthBar;

    [Header("Shooting Settings")]
    public GameObject projectilePrefab;
    public Transform shootPoint;

    [Tooltip("Time in seconds between each homing projectile shot")]
    public float timeBetweenShots = 3f;

    private bool isShootingLoopStarted = false;

    void Start()
    {
        currentHealth = maxHealth;

        if (healthBar != null)
        {
            healthBar.SetMaxHealth(maxHealth);
            healthBar.SetHealth(currentHealth);
        }
    }

    public void DamageVampire(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("Vampire Health: " + currentHealth);

        if (healthBar != null)
        {
            healthBar.SetHealth(currentHealth);
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // 1. This is still called by your Animation Event at the end of the clip!
    public void ShootHomingProjectile()
    {
        // Safety check so we don't start multiple loops
        if (!isShootingLoopStarted)
        {
            StartCoroutine(ShootingLoop());
        }
    }

    // 2. This coroutine handles the repeating attack cycle
    private IEnumerator ShootingLoop()
    {
        isShootingLoopStarted = true;

        // Loop forever until the vampire dies (and this GameObject is destroyed)
        while (true)
        {
            SpawnProjectile();

            // Wait for the specified cooldown time before shooting again
            yield return new WaitForSeconds(timeBetweenShots);
        }
    }

    // 3. Extracted the actual spawning logic into its own clean function
    private void SpawnProjectile()
    {
        if (projectilePrefab == null || shootPoint == null) return;

        GameObject proj = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

        HomingProjectile homingScript = proj.GetComponent<HomingProjectile>();
        if (homingScript != null)
        {
            homingScript.LinkToVampire(this);
        }
    }

    void Die()
    {
        Debug.Log("Vampire Defeated!");

        Instantiate(deathEffect, transform.position, Quaternion.identity);

        AudioManager audioManager = FindFirstObjectByType<AudioManager>();

        if (audioManager != null)
        {
            audioManager.PlaySFX(audioManager.vampiredeath);
        }

        Destroy(gameObject); // This automatically stops the coroutine loop
    }
}
