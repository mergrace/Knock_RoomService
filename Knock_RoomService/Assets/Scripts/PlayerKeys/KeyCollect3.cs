using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyCollect3 : MonoBehaviour
{
    public KeyManager3 cm3;
   //public GameObject escapePanel;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cm3.keyCount3++;
            audioManager.PlaySFX(audioManager.keycollect);

            SceneManager.LoadScene("Hallway");

            Destroy(gameObject);

            //escapePanel.SetActive(true);

            //Time.timeScale = 0f;
        }
    }
}
