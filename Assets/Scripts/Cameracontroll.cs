using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroll : MonoBehaviour {
    public PlayerController player;
    public Camera gameCamera;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameCamera.transform.position = new Vector3(
            Mathf.Lerp(gameCamera.transform.position.x, player.transform.position.x, 0.03f),
            player.transform.position.y,
            Mathf.Lerp(gameCamera.transform.position.z, player.transform.position.z-15, 0.03f));
            
	}
}
