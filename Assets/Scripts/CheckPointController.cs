using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour

{   
    public Sprite blackFlag;
    public Sprite redFlag;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;
  
    //GET COMPONENT ATTACHED TO GAME OBJECT 
    void Start()
    {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer> ();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {    
            //CHANGE SPRITE FROM RED FLAG TO GREEN FLAG
            checkpointSpriteRenderer.sprite = redFlag;
            checkpointReached = true;
        }
    }
}
