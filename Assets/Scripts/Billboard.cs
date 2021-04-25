using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    Camera myCamera;
    // Start is called before the first frame update
    void Start()
    {
        myCamera= GameObject.Find("PlayerCam").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = myCamera.transform.rotation;
    }
}
