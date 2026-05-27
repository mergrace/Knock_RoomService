using UnityEngine;

public class KeyCollect3 : MonoBehaviour
{
    public KeyManager cm3;
    public GameObject escapePanel;

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
            cm3.keyCount++;
            audioManager.PlaySFX(audioManager.keycollect);

            Destroy(gameObject);

            escapePanel.SetActive(true);

            Time.timeScale = 0f;
        }
    }
}
