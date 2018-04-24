using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class netID : MonoBehaviour
{
    // Create a list that stores every asset in it(On the server)
    // Asset ID is the number of stuff in the list +1
    public float AssetID;
    public float NetworkID;
    public float PlayerControllerID;
    public bool isClient;
    public bool isServer;

    // Update is called once per frame
    void Update()
    {

    }
}
