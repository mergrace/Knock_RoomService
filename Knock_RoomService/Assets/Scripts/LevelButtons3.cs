using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtons3 : MonoBehaviour
{
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
}
