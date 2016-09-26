using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour {
    private Vector3 startingPosition;

    private Rigidbody player;
	// Use this for initialization
	void Start () {
        startingPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
#if CHEATS
        theCheats();
#endif
	}

    void theCheats()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.R)) //reset the player to where we started the game
        {
            ResetPlayerStuff();
            player.transform.position = startingPosition;
        }
        if (Input.GetKeyDown(KeyCode.T)) //Reset player at the latest checkpoint
            CheckPointSystem.instance.ResetPlayer();
    }

    void ResetPlayerStuff()
    {
        player.velocity = Vector3.zero;
        player.angularVelocity = Vector3.zero;
    }
}
