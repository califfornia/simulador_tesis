using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class Mover2 : MonoBehaviour
{
    NavMeshAgent myNavMeshAgent;
    public Transform Objetivo;
    public Transform CheckPoint1;
    public Transform CheckPoint2;
    public float speed = -100f;
    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        SetDestinationToCheckPoint1();
    }

    void Update()
    { 
            if (Vector3.Distance(CheckPoint1.position, transform.position) < 5)
            {
                SetDestinationToObject();
            }
            if (Vector3.Distance(Objetivo.position, transform.position) < 5)
            {
                SetDestinationToCheckPoint2();
            }
    
    }

    void SetDestinationToObject()
    {
        myNavMeshAgent.SetDestination(Objetivo.position);

    }
    void SetDestinationToCheckPoint1()
    {
        myNavMeshAgent.SetDestination(CheckPoint1.position);

    }
        void SetDestinationToCheckPoint2()
    {
        myNavMeshAgent.SetDestination(CheckPoint2.position);

    }
}
