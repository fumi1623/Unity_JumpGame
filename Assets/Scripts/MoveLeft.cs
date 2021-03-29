using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20;
    private PlayerController playerControllerScript;
    //private float leftBound = -15;

    //Add me
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        //Add me
        startPos = transform.position;

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false) {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) {
        //    Destroy(gameObject);
        //}
        //Add me
        if (transform.position.x < -7 && gameObject.CompareTag("Obstacle")) {
            transform.position = startPos;
        }
        
    }
}
