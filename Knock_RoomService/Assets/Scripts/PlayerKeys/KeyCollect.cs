using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    public KeyManager cm;
    public GameObject levelCompletePanel;

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

            Destroy(gameObject);

            levelCompletePanel.SetActive(true);

            Time.timeScale = 0f;
        }
    }
}
