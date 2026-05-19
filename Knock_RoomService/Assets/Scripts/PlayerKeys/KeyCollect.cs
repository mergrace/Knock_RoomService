using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    public KeyManager cm;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            cm.keyCount++;
            audioManager.PlaySFX(audioManager.keycollect);
        }
    }
}
