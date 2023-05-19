using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    //array of waypoints
    int waypointIndex;
    //index for choosing the waypoints
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            //if the distance to the target is less than 1 meter then it will call upon these functions
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        //sets the target to the current waypoint
        agent.SetDestination(target);
        //sets the nav mesh agent's destination to the current target
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        //this will go to the next waypoint index increasing it by 1
        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
            //if the index is equal to the number of index's set it will loop back to the first one
        }
    }
}
