using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLayer : MonoBehaviour {

    public bool hasSwitchedLayers = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            if (hasSwitchedLayers)
            {
                this.transform.position = new Vector3(
                    this.transform.position.x,
                    this.transform.position.y,
                    0
                    );
            }
            else
            {
                this.transform.position = new Vector3(
                   this.transform.position.x,
                   this.transform.position.y,
                   10
                   );
            }
            hasSwitchedLayers = !hasSwitchedLayers;
        }
		
	}
}
