using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Movement : MonoBehaviour {

    public float Speed;
    public float JumpHeight;
    public float GroundDistance;
    
    public LayerMask Ground;

    public Rigidbody _rbody;
    private Vector3 _inputs = Vector3.zero;
    private bool _isGrounded = true;
    private Transform _groundChecker;

    private float lastTimeup;
    
    public GameObject jumpnow;


    // Use this for initialization
    void Start () {
        lastTimeup = -5;

        
    }
	
	// Update is called once per frame
	void Update () {

        _isGrounded = Physics.CheckSphere(transform.position - new Vector3 (0f, .5f, 0f), GroundDistance, Ground, QueryTriggerInteraction.Ignore);

        _inputs = Vector3.zero;
        if (!_isGrounded)
        {
            _inputs.x = Input.GetAxis("Horizontal");
            _inputs.z = Input.GetAxis("Vertical");
            jumpnow.GetComponent<Image>().color = Color.red;
        }
        if (_isGrounded)
        {
            _inputs.x = Input.GetAxis("Horizontal") * 0.5f;
            _inputs.z = Input.GetAxis("Vertical") * 0.5f;
            jumpnow.GetComponent<Image>().color = Color.green;
        }


        if (Input.GetKeyDown("space") && _isGrounded)
        {
            _rbody.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
        }

        if (Input.GetKey("x") && Time.time - lastTimeup > 5)
        {
            _rbody.AddForce(0,275,0);
            lastTimeup = Time.time;
        }

    }



    void FixedUpdate()
    {
        _rbody.MovePosition(_rbody.position + _inputs * Speed * Time.fixedDeltaTime);
    }
}
