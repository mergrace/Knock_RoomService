using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChangerHallway : MonoBehaviour
{
    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();

        if (audioManager == null)
        {
            Debug.LogError("AudioManager NOT FOUND in scene!");
        }
    }

    public void GoToRoom1()
    {
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        if (audioManager != null)
        {
            audioManager.PlayKnock();
        }

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("Room 1");
    }
}