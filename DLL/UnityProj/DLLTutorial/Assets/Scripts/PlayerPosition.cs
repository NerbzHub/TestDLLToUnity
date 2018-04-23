using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public GameObject[] playerArray;

    // Use this for initialization
    void Start()
    {
        // Player one       10, 0, 10
        // Player two       10, 0, -10
        // Player three     -10, 0, 10
        // Player four      -10, 0, -10

    }

    // Update is called once per frame
    void Update()
    {
        getPlayerPosition(playerArray[2], "x");
        getPlayerPosition(playerArray[1], "z");

    }

    // Takes in a player from the array and a string to say which axis it is.
    public float getPlayerPosition(GameObject player, string axis)
    {
        // float to be returned
        float playerAxisValue = 0;

        // checks which axis is wanted to be sent.
        switch (axis)
        {
            case "x":
                playerAxisValue = player.gameObject.transform.position.x;
                break; 

            case "y":
                playerAxisValue = player.gameObject.transform.position.y;
                break;

            case "z":
                playerAxisValue = player.gameObject.transform.position.z;
                break;
        }
        // outputs the value to the console.
        Debug.Log(playerAxisValue);
        // return the axis value;
        return playerAxisValue;
    }
}
