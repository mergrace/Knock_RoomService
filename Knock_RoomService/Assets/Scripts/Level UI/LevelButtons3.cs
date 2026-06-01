using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtons3 : MonoBehaviour
{
    public GameObject levelCompletePanel;

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Hallway");
    }

    public void ClosePanel()
    {
        levelCompletePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
