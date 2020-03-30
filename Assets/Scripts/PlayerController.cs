using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float moveForce;
    public float jumpForce;
    private bool canJump;
    public int checkPoint;
    public SwitchLayer alma;
    // Use this for initialization
    void Start () {
        checkPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a"))
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(
                -moveForce * Time.deltaTime,
                this.GetComponent<Rigidbody>().velocity.y,
                this.GetComponent<Rigidbody>().velocity.z
                );
        }
        if (Input.GetKey("d"))
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(
                moveForce * Time.deltaTime,
                this.GetComponent<Rigidbody>().velocity.y,
                this.GetComponent<Rigidbody>().velocity.z
                );
        }
        if (Input.GetKeyDown("w") && canJump)
        {
            canJump = false;
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        canJump = true;

        if(collision.gameObject.name == "LVL_1_Portal")
        {
            checkPoint = 1;
            this.transform.position = new Vector3(35, 2, 0);
            alma.hasSwitchedLayers = false;
        }

        if (collision.gameObject.name == "LVL_2_Portal")
        {
            checkPoint = 2;
            this.transform.position = new Vector3(85, 3, 0);
            alma.hasSwitchedLayers = false;
        }

        if (collision.gameObject.name == "LVL_3_Portal")
        {
            checkPoint = 0;
            SceneManager.LoadScene("Intermediate");
            alma.hasSwitchedLayers = false;
        }
        if (collision.gameObject.name == "respawn")
        {
            if (checkPoint == 0){this.transform.position = new Vector3(-14, 3, 0);}else if (checkPoint == 1) {this.transform.position = new Vector3(35, 2, 0);}else if(checkPoint == 2) {this.transform.position = new Vector3(85, 3, 0);}
            alma.hasSwitchedLayers = false;
        }
    }
}
