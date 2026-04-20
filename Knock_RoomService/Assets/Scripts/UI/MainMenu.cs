 using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Hallway");
    }


    public void QuitGame()
    {
        Debug.Log("Game has been quit");
        Application.Quit();
    }
}
