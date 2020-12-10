using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float safesSpeed;
    public float jumpForce;

    public Rigidbody hips,hips2;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        hips = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            hips.AddForce(hips.transform.forward * speed);
        }else 
        if (Input.GetKey(KeyCode.D))
        {
            hips.AddForce(-hips.transform.forward * speed);
        }
        else
        if (Input.GetKey(KeyCode.S))
        {
            hips.AddForce(-hips.transform.right * speed);
        }else 
        if (Input.GetKey(KeyCode.W))
        {
            hips.AddForce(hips.transform.right* speed);
        }else if (Input.GetKey(KeyCode.LeftShift))
        {
            if (isGrounded)
            {
                hips.AddForce(new Vector3(0, jumpForce,0));
                isGrounded = false;
            }
        }

        // controller 2
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hips2.AddForce(hips.transform.forward * speed);
        }
        else
            if (Input.GetKey(KeyCode.RightArrow))
        {
            hips2.AddForce(-hips.transform.forward * speed);
        }
        else
            if (Input.GetKey(KeyCode.DownArrow))
        {
            hips2.AddForce(-hips.transform.right * speed);
        }
        else
            if (Input.GetKey(KeyCode.UpArrow))
        {
            hips2.AddForce(hips.transform.right * speed);
        }
        else 
            if (Input.GetKey(KeyCode.RightShift))
        {
            if (isGrounded)
            {
                hips2.AddForce(new Vector3(0, jumpForce, 0));
                isGrounded = false;
            }
        }

    }
}
