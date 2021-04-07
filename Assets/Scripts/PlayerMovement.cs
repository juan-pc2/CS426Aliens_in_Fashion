// using __ imports namespace
// Namespaces are collection of classes, data types
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

// MonoBehavior is the base class from which every Unity Script Derives
public class PlayerMovement : NetworkBehaviour
{
    public float speed = 25.0f;
    public float rotationSpeed = 50.0f;
    public float force = 700f;

    Rigidbody rb;
    Transform t;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
            return;

        // Time.deltaTime represents the time that passed since the last frame
        //the multiplication below ensures that GameObject moves constant speed every frame
        if (Input.GetKey(KeyCode.W)){
            rb.AddRelativeForce(Vector3.forward * force);
            anim.Play("Walking");
        }
        else if (Input.GetKey(KeyCode.S)){
            rb.AddRelativeForce(Vector3.back * force);
            anim.Play("Walking");
        }

        // Quaternion returns a rotation that rotates x degrees around the x axis and so on
        if (Input.GetKey(KeyCode.D)){
            this.t.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A)){
            this.t.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(t.up * force);
    }
}