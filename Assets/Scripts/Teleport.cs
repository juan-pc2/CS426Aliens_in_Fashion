using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    private Transform destination;
    public GameObject destinationPortal;

    // Start is called before the first frame update
    void Start()
    {
        destination = destinationPortal.GetComponent<Transform>();
    }

    void OnTriggerEnter(Collider player)
    {
            player.transform.position = new Vector3(destination.position.x, destination.position.y, destination.position.z);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
