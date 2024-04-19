using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    public NavMeshAgent monster;
    public Transform Player;

    void Update()
    {
        monster.SetDestination(Player.position);
    }
}
