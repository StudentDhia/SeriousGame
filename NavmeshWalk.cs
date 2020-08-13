using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshWalk : MonoBehaviour
{
    public GameObject[] Path;
    public NavMeshAgent agent;
    private Animator animator;
    private int i = 0;
    private bool walk = true;
    private Vector3 StopPosition;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        agent.SetDestination(Path[i].transform.position);
        
        if(Path[i].GetComponent<PathPositions>().hit == true && Path[i].GetComponent<PathPositions>().noNext == false)
        {
            i++;
        }

        if(Path[i].GetComponent<PathPositions>().hit == true && Path[i].GetComponent<PathPositions>().noNext == true)
        {
            //animator.SetBool("Walking", false);
            walk = false;
        }

        animator.SetBool("Walking", walk);

        if(walk == false && Path[i].GetComponent<PathPositions>().noNext == false)
        {
            transform.position = StopPosition;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if ((other.tag == "Player") && (Input.GetKeyDown("space")))
        {
            agent.speed = 0;
            agent.isStopped = true;
            agent.ResetPath();
            walk = false;
            StopPosition = transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            agent.speed = 6;
            agent.isStopped = false;
            walk = true;
        }
    }
}
