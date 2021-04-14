using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    private GameObject player;
    public float distance = 20.0f;
    public float chaseSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (Vector3.Distance(transform.position, player.transform.position) < distance)
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, chaseSpeed);
    }
}
