using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{
    public GameObject wayPoint;

    private float timer = 0.5f;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            UpdatePosition();
            timer = 0.5f;
        }
    }
    void UpdatePosition()
    {
        wayPoint.transform.position = transform.position;
    }
}

//AI was used to help write this script