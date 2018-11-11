using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //player attributes
    float playerlocX = 0f;
    float playerlocY = 0f;
    float playerlocZ = 0f;

    float movementSpeed = 3f;

    int playerHealth = 3;

    bool isPlayerAlive = false;

    


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        /* Sample code
        playerlocX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        playerlocY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Rotate(0, playerlocX, 0);
        transform.Translate(0, 0, playerlocY);
        */

        checkForMovement();
   
    }

    public void checkForMovement()
    {
        playerlocX = Input.GetAxis("Horizontal");
        playerlocY = Input.GetAxis("Vertical");
    }
}
