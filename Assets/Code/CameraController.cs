using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
    {

    public bool followPlayer;
    public int scale;

    GameObject player;
    Camera orthcamera;

    void Start()
        {
        player = GameObject.Find("Player");
        orthcamera = GetComponent<Camera>();
        //orthcamera.orthographicSize = 1080 / (32 * 2 * scale);
        }

    void Update()
        {
		if (followPlayer)
            {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
            }
	    }
}
