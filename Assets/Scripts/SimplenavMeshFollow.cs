using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimplenavMeshFollow : MonoBehaviour
{
    public Transform m_target;
    NavMeshAgent m_agent;
    private void Start()
    {
        m_agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        m_agent.SetDestination(m_target.position);
    }
}
