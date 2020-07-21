using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AutoPathing : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform target,target2,target3;
    public float stopDistance = 2;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(target.position);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target.position) < stopDistance)
        {
            Destroy(gameObject);
        }
    }
}
