using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalk : MonoBehaviour
{
    public GameObject destination;
    private Transform destinationTransform;
    private Transform currentTransform;
    public float moveSpeed = 0.1f;
    private bool animationDone = false;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        currentTransform = GetComponent<Transform>();
        destinationTransform = destination.GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTransform.position = Vector3.MoveTowards(currentTransform.position, destinationTransform.position, moveSpeed);
        anim.Play("Walking");
        if(currentTransform.position == destinationTransform.position)
        {
            anim.Play("Waving");
            animationDone=true;
        }
        if(animationDone){
            animationDone=false;
            Destroy(gameObject);
            Destroy(destination.gameObject);
        }
    }
}
