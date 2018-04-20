using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour {
    Renderer rend;
	// Use this for initialization
	void Start () {
        rend = gameObject.GetComponent<MeshRenderer>();
        rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (PersistentManager.Instance.Score >= 5)
        {
            rend.enabled = true;
        }
    }

    void OnTriggerEnter(Collider other) {
        if (PersistentManager.Instance.Score == 5) {
            SceneManager.LoadScene("Scene2");

        }
    }
}
