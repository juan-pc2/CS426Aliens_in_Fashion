using UnityEngine;
using System.Collections;
 
public class BoidController : MonoBehaviour
{
    public float minVelocity = 5;
    public float maxVelocity = 20;
    public float randomness = 1;
    public int flockSize = 20;
    public GameObject prefab;
    public GameObject chasee;
 
    public Vector3 flockCenter;
    public Vector3 flockVelocity;
 
    private GameObject[] boids;
    private Collider coll;
    private Rigidbody rb;
    // private Transform t;
 
    void Start()
    {
        boids = new GameObject[flockSize];
        coll = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        // t = GetComponent<Transform>();
        for (var i=0; i<flockSize; i++)
        {
            Vector3 position = new Vector3 (
                Random.value * coll.bounds.size.x,
                Random.value * coll.bounds.size.y,
                Random.value * coll.bounds.size.z
            ) - coll.bounds.extents;
 
            GameObject boid = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
            boid.transform.parent = transform;
            boid.transform.localPosition = position;
            if (this == null) boid.GetComponent<BoidFlocking>().SetController(gameObject);
            boids[i] = boid;
        }
    }
 
    void Update ()
    {
        Vector3 theCenter = Vector3.zero;
        Vector3 theVelocity = Vector3.zero;
 
        foreach (GameObject boid in boids)
        {
            if (this == null) {
                theCenter = theCenter + boid.GetComponent<Transform>().localPosition;
                theVelocity = theVelocity + boid.GetComponent<Rigidbody>().velocity;
            }
        }
 
        flockCenter = theCenter/(flockSize);
        flockVelocity = theVelocity/(flockSize);
    }
}