using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    public NavMeshAgent monster;
    public Transform Player;

    private float monsterSpeed = 5f;

    void Update()
    {
        monster.speed = monsterSpeed;

        monster.SetDestination(Player.position);
    }
}