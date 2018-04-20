using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour {
    public Camera c;
    public Shader cel;
    public GameObject player;
    public int camDist = 2;

    float x;
    float z;
	// Use this for initialization
	void Start () {
        //c.SetReplacementShader(cel,"");
    }
	
	// Update is called once per frame
	void Update () {
        var pos = transform.position;
        var playerPos = player.transform.position;
        if (pos.x < playerPos.x - camDist) {
            x = playerPos.x - camDist;
        }
        else if (pos.x > playerPos.x + camDist)
        {
            x = playerPos.x + camDist;
        }
        if (pos.z < playerPos.z - camDist - 4)
        {
            z = playerPos.z - camDist -4;
        }
        else if (pos.z > playerPos.z -camDist -2)
        {
            z = playerPos.z - camDist - 2 ;
        }
        transform.position = new Vector3(x, pos.y, z);
	}
}
