using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Quitgame()
    {
        Application.Quit();
    }

   
    
}
