using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Transform gameobj;
    public float speedxax;
    public Rigidbody2D rbody;
    public float canJump = 0f;
    public float jumpForce;
    public Vector2 Vel;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        
        ///gameobj.position += new Vector3(xax * Time.deltaTime * speedxax, 0f, 0f);
        
     
    }
    void FixedUpdate()
    {   
        

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
        }

        
    }
}
