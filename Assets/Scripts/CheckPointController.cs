using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour

{   
    public Sprite blackFlag;
    public Sprite redFlag;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;
  
    void Start()
    {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer> ();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            checkpointSpriteRenderer.sprite = redFlag;
            checkpointReached = true;
        }
    }
}
