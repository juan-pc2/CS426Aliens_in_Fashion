using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    private Transform destination;
    private UIManage UIScript;

    public GameObject UIObject;
    public GameObject destinationPortal;
    public bool alwaysOpen;

    // Start is called before the first frame update
    void Start()
    {
        destination = destinationPortal.GetComponent<Transform>();
        UIScript = UIObject.GetComponent<UIManage>();
    }

    void OnTriggerEnter(Collider player)
    {
        if (alwaysOpen || openPortal())
        {
            player.transform.position = new Vector3(destination.position.x, destination.position.y, destination.position.z);
        }
    }

    bool openPortal()
    {
        if (UIScript.numAliensHired > 0 && UIScript.fashionItems >= 3)
            return true;

        return false;
    }
}


