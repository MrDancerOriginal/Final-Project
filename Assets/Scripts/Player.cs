using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    NavMeshAgent myNavMeshAgent;
    Animator animator;

    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        Debug.Log(myNavMeshAgent.hasPath);

        if (myNavMeshAgent.hasPath == true)
        {
            //Відбуватись анімація ходьби
            animator.SetBool("isWalking", true);
        }
        else
        {

        }

        if (Input.GetMouseButtonDown(0))
        {
            SetDestinationToMousePosition();
        }
    }

    void SetDestinationToMousePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            myNavMeshAgent.SetDestination(hit.point);
        }
    }
}
