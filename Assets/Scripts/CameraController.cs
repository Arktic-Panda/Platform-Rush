using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float offset;
    private Vector3 playerPosition;
    public float LerpTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ADJUSTING TRANSFORM OF CAMERA TO TRASFORM OF PLAYER

        playerPosition = new Vector3 (player.transform.position.x, transform.position.y, transform.position.z);
        
        //MOVE CAMERA RIGHT
        if(player.transform.localScale.x > 0f)
        {
            playerPosition = new Vector3 (playerPosition.x + offset, playerPosition.y, playerPosition.z);
        }
        //MOVE CAMERA LEFT
        else 
        {
            playerPosition = new Vector3 (playerPosition.x - offset, playerPosition.y, playerPosition.z);
        }
        transform.position = Vector3.Lerp (transform.position, playerPosition, LerpTime * Time.deltaTime);
    }
}
