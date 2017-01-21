using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour
{
    void Start()
    {
        if (isServer)
        {
            GameState state = new GameState();
        }
        Debug.Log("Started");
        Debug.Log(isServer);
        Debug.Log(isLocalPlayer);
    }

    void Update()
    {
        if (!isLocalPlayer)
            return;

        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        


        transform.Translate(x, 0, z);
    }
}
