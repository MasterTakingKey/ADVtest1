using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NinjaNavMeshmng : MonoBehaviour
{

    private Animator anim;
    private NavMeshAgent agent;

    [SerializeField]
    private Camera camara;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camara.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.destination = hit.point;
            }
        }
        anim.SetFloat("horizontal", transform.InverseTransformDirection(agent.velocity).x);
        anim.SetFloat("vertical", transform.InverseTransformDirection(agent.velocity).z);
        if (agent.isOnOffMeshLink) 
        {
            //anim.SetTrigger("jump"); 
            Debug.Log("Salto");
        }
    }
}
