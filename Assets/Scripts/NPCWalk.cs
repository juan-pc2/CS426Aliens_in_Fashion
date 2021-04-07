using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalk : MonoBehaviour
{
    private CharacterController controller;
    private Rigidbody rb;
    public GameObject destination;
    private Transform destinationTransform;
    private Transform currentTransform;
    private Rigidbody destinationBody;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        currentTransform = GetComponent<Transform>();
        destinationTransform = destination.GetComponent<Transform>();
        destinationBody = destination.GetComponent<Rigidbody>();
        moveSpeed = 20.0f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position != destinationBody.position)
        {
            rb.AddRelativeForce(Vector3.forward * moveSpeed);
        }
        else
            rb.velocity = Vector3.zero;
    }
}
