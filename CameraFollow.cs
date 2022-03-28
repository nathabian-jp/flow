using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public float cameraZ = 0f;
    public float cushion = 0f;
    public float playerX;
    public float playerY;
    public GameObject player;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
        playerX = player.transform.position.x;
        playerY = player.transform.position.y;

        transform.position = new Vector3(playerX - cushion, playerY, cameraZ);

	}
}
