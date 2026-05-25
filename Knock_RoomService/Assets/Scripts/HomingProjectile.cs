using UnityEngine;

public class HomingProjectile : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 2f;
    private Transform player;

    [Header("Vampire Link")]
    private VampireHealth vampireHealth;
    public int selfDestructDamageToVampire = 25; // Massive damage!

    void Start()
    {
        // Find the player by tag
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null) player = playerObj.transform;
    }

    // Call this right after Instantiating the projectile to link it to the vampire
    public void LinkToVampire(VampireHealth healthScript)
    {
        vampireHealth = healthScript;
    }

    void Update()
    {
        if (player == null) return;

        // Move slowly towards the player's current position
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    // Called when the player's bullet hits this projectile
    public void TakeDamage()
    {
        if (vampireHealth != null)
        {
            // Deal massive damage to the boss
            vampireHealth.DamageVampire(selfDestructDamageToVampire);
        }

        // Spawn an explosion effect here if you want!
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Deal damage to the player here
            Destroy(gameObject);
        }
    }
}
