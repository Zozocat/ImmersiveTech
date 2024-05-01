using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteKey : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lock")
        {
            gameObject.SetActive(false);
        }
    }
}


//AI was used to help write this script