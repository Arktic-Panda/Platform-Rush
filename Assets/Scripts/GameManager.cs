using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public float respawnDelay;
    public PlayerController gamePlayer;
    public int coins;
    public Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        gamePlayer = FindObjectOfType<PlayerController> ();
        coinText.text = "Coins : " + coins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins (int numberOfCoins)
    {
        coins += numberOfCoins;
        coinText.text = "Coins : " + coins;
    }
}
