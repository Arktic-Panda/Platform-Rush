using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{   
    private GameManager gameLevelManager;
    public int coinValue;
    // Start is called before the first frame update
    void Start()
    {
        //FIND GAME MANAGEMENT SCRIPT
        gameLevelManager = FindObjectOfType<GameManager> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
        //ADD COINS TO SCORE AND DESTROY THE COIN
        gameLevelManager.AddCoins(coinValue);
        Destroy (gameObject);
        }
        
    }
}
