using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalk : MonoBehaviour
{
    public GameObject destination;
    private Transform destinationTransform;
    private Transform currentTransform;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentTransform = GetComponent<Transform>();
        destinationTransform = destination.GetComponent<Transform>();
        moveSpeed = 0.10f;
    }

    // Update is called once per frame
    void Update()
    {
        currentTransform.position = Vector3.MoveTowards(currentTransform.position, destinationTransform.position, moveSpeed);
        if(currentTransform.position == destinationTransform.position)
        {
            Destroy(gameObject);
            Destroy(destination.gameObject);
        }
    }
}
