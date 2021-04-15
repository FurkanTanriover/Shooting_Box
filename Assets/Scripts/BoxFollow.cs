using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BoxFollow : MonoBehaviour
{

    public NavMeshAgent box;
    public Transform player;

    void Start()
    {
        
    }


    void Update()
    {
        box.SetDestination(player.position);
    }
}
