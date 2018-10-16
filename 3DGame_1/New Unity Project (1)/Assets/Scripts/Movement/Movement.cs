using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float Speed;
    public float JumpHeight;
    public float GroundDistance;
    public float DashDistance;
    public LayerMask Ground;

    public Rigidbody _rbody;
    private Vector3 _inputs = Vector3.zero;
    private bool _isGrounded = true;
    private Transform _groundChecker;




	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        _isGrounded = Physics.CheckSphere(transform.position - new Vector3 (0f, .5f, 0f), GroundDistance, Ground, QueryTriggerInteraction.Ignore);

        _inputs = Vector3.zero;
        _inputs.x = Input.GetAxis("Horizontal");
        _inputs.z = Mathf.Abs(Input.GetAxis("Vertical"));
        

        if (Input.GetKeyDown("space") && _isGrounded)
        {
            _rbody.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown("d"))
        {
            Vector3 dashVelocity = Vector3.Scale(transform.forward, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * _rbody.drag + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * _rbody.drag + 1)) / -Time.deltaTime)));
            _rbody.AddForce(dashVelocity, ForceMode.VelocityChange);
        }

    }



    void FixedUpdate()
    {
        _rbody.MovePosition(_rbody.position + _inputs * Speed * Time.fixedDeltaTime);
    }
}
