using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//BUTTON UI SCRIPT
public class MainMenu : MonoBehaviour
{  
    //LOAD GAME SCENE
   public void PlayGame()
   {
   SceneManager.LoadScene(1);
   }
    //CLOSE GAME 
    public void QuitGame()
   {
       Application.Quit();
   }
    //LOAD CONTROLS(PLAYER CONTROL) SCENE
    public void Controls()
   {
   SceneManager.LoadScene(2);
   }
}
