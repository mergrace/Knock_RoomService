using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeRoom2 : MonoBehaviour
{

    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void GoToRoom2()
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

        SceneManager.LoadScene("Room 2");
    }
}
