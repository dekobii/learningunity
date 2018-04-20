using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    float dx = 0;
    float dz = 0;
    public float walkSpeed = 5;
    Rigidbody rb;
    private float xSpeed;
    private float zSpeed;
    private Animator m_Animator;
    public GameObject joke;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        var spaceDown = Input.GetKey(KeyCode.Space);
        if (spaceDown)
            joke.GetComponent<MeshRenderer>().enabled = true;
        else
            joke.GetComponent<MeshRenderer>().enabled = false;


        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        if (transform.position.x < -4 && x < 0)
            x = 0;
        if (transform.position.x > 34 && x > 0)
            x = 0;
        if (transform.position.z < -4 && z < 0)
            z = 0;
        if (transform.position.z > 4 && z > 0)
            z = 0;
        transform.Translate(new Vector3(x, 0, z), Space.World);
        //rb.velocity += new Vector3(xSpeed, 0, zSpeed);

        m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.speed = 0.01f;

        // Test
        // Another test for git
    }

    private void FixedUpdate()
    {
        



    }
}
