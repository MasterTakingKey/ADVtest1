using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LampManager : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        agent.destination = player.transform.position;

        Debug.Log("posicion de player" + agent.destination);

    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position;

    }
}
