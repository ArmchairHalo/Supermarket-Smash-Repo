using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if(Mathf.Abs(input.y) > 0.01f)
        {
            Move(input);
        }
        else
        {
            Rotate(input);
        }
    }

    private void Rotate(Vector2 input)
    {
        navMeshAgent.destination = transform.position;
        transform.Rotate(0, input.x * navMeshAgent.angularSpeed * Time.deltaTime, 0);
    }

    private void Move(Vector2 input)
    {
        Vector3 destination =
            transform.position + transform.right * input.x + transform.forward * input.y;
        navMeshAgent.destination = destination;
    }
}
