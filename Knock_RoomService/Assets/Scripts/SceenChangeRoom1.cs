using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceenChangeRoom1 : MonoBehaviour
{
   public void GoToHallway()
    {
        SceneManager.LoadScene("Hallway");
    }
}
