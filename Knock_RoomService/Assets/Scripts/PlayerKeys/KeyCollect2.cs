using UnityEngine;

public class KeyCollect2 : MonoBehaviour
{
    public KeyManager cm2;
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
            cm2.keyCount++;
            audioManager.PlaySFX(audioManager.keycollect);
        }
    }
}
