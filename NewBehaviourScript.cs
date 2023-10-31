using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

  // This is where we assign our varibles as the variable type (float variables), this is also where we assign the code to have a Rigidbody.
    float xValue;
    float yValue;
    float zValue;
    float playerSpeed;
    float jumpHeight;
    Rigidbody playerRB;


    // Start is called before the first frame update
    void Start()
    {
        // This is where we assign the speed of the player, and make sure that there is no pre-existing y-value that can mess with our players jump.
        playerSpeed = 5.25f;
        yValue = 0;
        PrepareToJump();

    }

    // Update is called once per frame
    void Update()
    {
       // By placing a moveme and makemejump in update, it allows for the player to do these actions repeatedly.
        MoveMe();
        MakeMeJump();

    }

    void MoveMe()
    {
        // This allows the movement of the player both horizontally and vertically to be synced to all computers and the players speed
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;

        zValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;

        transform.Translate(xValue, yValue, zValue);

    }

    void PrepareToJump()
    {
        // This allows for the player to have a rigidbody component without doing it in Unity, and sets the jumpheight of the player to 10
        playerRB = GetComponent<Rigidbody>();

        jumpHeight = 10f;

    }

    void MakeMeJump()
    {
        //This allows for the player to have their jumpheight timed with the rigidbodt component
        playerRB.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);

    }


}
