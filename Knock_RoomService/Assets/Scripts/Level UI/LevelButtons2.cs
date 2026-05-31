using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtons2 : MonoBehaviour
{
    public GameObject levelCompletePanel;

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ClosePanel()
    {
        levelCompletePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
