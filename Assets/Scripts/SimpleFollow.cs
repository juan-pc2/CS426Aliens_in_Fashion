//Can Yuva
//Unity 5 Enemy Follow to Player C# Script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollow : MonoBehaviour
{

    CharacterController _controller;
    Transform target;
    GameObject Player;

    [SerializeField]
    float _moveSpeed = 5.0f;
    Animator anim;

    // Use this for initialization
    void Start()
    {

        Player = GameObject.FindWithTag("Player");
        target = Player.transform;
        anim = GetComponent<Animator>();
        _controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;
        Vector3 velocity = direction * _moveSpeed;
        // if (transform.position == (target.position - target.forward)){
        //     direction = target.position - transform.position - target.forward;
        //     direction = direction.normalized;
        //     velocity = direction * _moveSpeed;
        // }
        _controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
            anim.Play("Walking");
        }
    }
}
