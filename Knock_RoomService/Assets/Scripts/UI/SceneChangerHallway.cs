using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneChangerHallway : MonoBehaviour
{
    public void GoToRoom1()
    {
        SceneManager.LoadScene("Room 1");
    }
}
