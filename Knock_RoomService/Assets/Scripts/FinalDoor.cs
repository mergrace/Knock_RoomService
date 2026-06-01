using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    public GameObject escapePanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            escapePanel.SetActive(true);

            Time.timeScale = 0f;
        }
    }
}