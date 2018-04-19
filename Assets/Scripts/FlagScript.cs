using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour {
    public Material greenFlag;
    AudioSource coinSound;
    bool done = false;
	// Use this for initialization
	void Start () {
        coinSound = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter() {
        if (!done)
        {
            gameObject.GetComponent<Renderer>().material = greenFlag;
            coinSound.Play();
            PersistentManager.Instance.Score += 1;
            done = true;
        }
    }
}
