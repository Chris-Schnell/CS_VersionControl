using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public AudioSource jumpsound;
    public Transform gameobj;
    public float speedxax;
    public Rigidbody2D rbody;
    public float canJump = 0f;
    public float jumpForce;
    public Vector2 Vel;
    private bool facingLeft;
    public Animator myanimator;

    // Use this for initialization
    void Start () {
        facingLeft = true;
        
	}
	
	// Update is called once per frame
	void Update () {

        float horiz = Input.GetAxis("Horizontal");
        flip(horiz);
        }
    private void flip(float horiz){
        if (horiz < 0 && !facingLeft || horiz > 0 && facingLeft)
        {
            facingLeft = !facingLeft;
            Vector3 myScale = transform.localScale;
            myScale.x *= -1;
            transform.localScale = myScale;
        }

        ///gameobj.position += new Vector3(xax * Time.deltaTime * speedxax, 0f, 0f);


    }
    void FixedUpdate()
    {

        myanimator.SetFloat("Player_Speed", Mathf.Abs(rbody.velocity.x));

        
        if (Physics2D.Raycast(rbody.position, -gameobj.transform.up, 1f))
        {

            myanimator.SetBool("inair", true);
        }
        else
        {
            myanimator.SetBool("inair", false);
        }

        if (Input.GetKey("left"))
        {
            

            Vel = new Vector2(speedxax * -1, 0f);
                rbody.AddForce(Vel, ForceMode2D.Force);
                
            
        }
        if (Input.GetKey("right"))
        {

            Vel = new Vector2(speedxax, 0f);
            rbody.AddForce(Vel, ForceMode2D.Force);
            

        }


        if (Input.GetKeyDown("space") && Time.time > canJump)
        {
            rbody.AddForce(new Vector2(0f, jumpForce),ForceMode2D.Impulse);
            canJump = Time.time + 1f;
            jumpsound.Play();
        }

        
    }
}
