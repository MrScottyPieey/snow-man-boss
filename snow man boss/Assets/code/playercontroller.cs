
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

    public float movex;
    public float speed;
    public float jumpForce;

    public AudioSource jumping;
    

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        movex = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(movex * speed, rb2d.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);

            
        }
    }
}
