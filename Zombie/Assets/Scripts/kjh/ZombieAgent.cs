using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAgent : MonoBehaviour
{
    private NavMeshAgent agent;
    public LayerMask whatIsTarget;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            /*
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 100);
            RaycastHit hit;
            if(Physics.Raycast(ray.origin, ray.direction, out hit, 100))
            {
                Debug.Log(hit.point);
                agent.isStopped = false;
                agent.SetDestination(hit.point);
            }
            */
            Physics.OverlapSphere(this.transform.position, 3);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, 3);
    }
}
