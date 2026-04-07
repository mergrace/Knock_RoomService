using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Hallway");
    }
   
      public void QuitGame()
    {
        Application.Quit();
    }
        
    
}
