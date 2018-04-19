using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var pos = transform.position;
        transform.position = new Vector3(player.transform.position.x, pos.y, player.transform.position.z -4);
	}
}
