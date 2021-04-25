using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFSM : FSM
{
    public enum FSMState
    {
        None,
        Patrol,
        Chase,
    }

    public FSMState curState;
    public int planetNum;
    private float curSpeed;
    private float curRotateSpeed;
    
    protected override void Initialize()
    {
        curState = FSMState.Patrol;
        curSpeed = 5.0f;
        curRotateSpeed = 3.0f;
        
        switch (planetNum)
        {
            case 1:
                pointList = GameObject.FindGameObjectsWithTag("WanderPoint1");
                break;
            case 2:
                pointList = GameObject.FindGameObjectsWithTag("WanderPoint2");
                break;
            case 3:
                pointList = GameObject.FindGameObjectsWithTag("WanderPoint3");
                break;
            case 4:
                pointList = GameObject.FindGameObjectsWithTag("WanderPoint4");
                break;
            default:
                break;
        }

        FindNextPoint();
    }

    

    protected override void FSMUpdate()
    {
        GameObject objPlayer = GameObject.FindGameObjectWithTag("Player");
        playerTransform = objPlayer.transform;

        if (!playerTransform)
            print("Player doesn't exist");

        switch (curState)
        {
            case FSMState.Patrol:
                UpdatePatrolState();
                break;
            case FSMState.Chase:
                UpdateChaseState();
                break;
        }
    }

    protected void UpdatePatrolState()
    {
        if (Vector3.Distance(transform.position, destPos) <= 2.5f)
        {
            print("Reached destination");
            FindNextPoint();
        }
        else if (playerTransform && Vector3.Distance(transform.position, playerTransform.position) <= 15.0f)
        {
            print("Switch to Chase state");
            curState = FSMState.Chase;
        }

        Quaternion targetRotation = Quaternion.LookRotation(destPos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * curRotateSpeed);

        transform.Translate(Vector3.forward * Time.deltaTime * curSpeed);
    }

    protected void FindNextPoint()
    {
        print("Finding next point");

        int rndIndex = Random.Range(0, pointList.Length);
        float rndRadius = 5.0f;
        Vector3 rndPosition = Vector3.zero;
        destPos = pointList[rndIndex].transform.position + rndPosition;

        if (IsInCurrentRange(destPos))
        {
            rndPosition = new Vector3(Random.Range(-rndRadius, rndRadius), 0.0f, Random.Range(-rndRadius, rndRadius));
            destPos = pointList[rndIndex].transform.position + rndPosition;
        }
    }

    protected bool IsInCurrentRange(Vector3 pos)
    {
        float xPos = Mathf.Abs(pos.x - transform.position.x);
        float zPos = Mathf.Abs(pos.z - transform.position.z);

        if (xPos <= 8 && zPos <= 8)
            return true;
        return false;
    }

    protected void UpdateChaseState()
    {
        destPos = playerTransform.position;
        float dist = Vector3.Distance(transform.position, playerTransform.position);

        if (dist >= 15.0f)
        {
            curState = FSMState.Patrol;
            FindNextPoint();
        }

        Quaternion targetRotation = Quaternion.LookRotation(destPos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * curRotateSpeed);

        transform.Translate(Vector3.forward * Time.deltaTime * curSpeed);
    }
}
