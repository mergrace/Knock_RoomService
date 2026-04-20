using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScriipt : MonoBehaviour
{
    public GameObject gameOverUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { 
    
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
        
    
    public void restart()
    {
        SceneManager.LoadScene("Hallway");

    }

  
    public void mainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
