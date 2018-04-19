using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboarding : MonoBehaviour {
    Camera mainCam;
	// Use this for initialization
	void Start () {
        mainCam = Camera.main;
        transform.rotation = mainCam.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
    }
}
