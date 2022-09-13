using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
   {
        //LOAD GAME OVER SCENE ON COLLISION WITH PLAYER
       if(other.tag == "Player")
       {
           SceneManager.LoadScene(3);
       }
   }
}
