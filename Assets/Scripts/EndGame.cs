using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
   public void ReturnToMenu()
   {
   //LOAD MAIN MENU SCREEN FOR BUTTON UI
   SceneManager.LoadScene(0);
   }
}
