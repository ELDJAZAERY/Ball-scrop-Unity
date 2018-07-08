using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramotor : MonoBehaviour {

    public GameObject player;

    public float xOffset,yOffset,zOffset;

	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(player.transform.position);
	}
}
