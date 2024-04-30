using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject endScreen;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hi");
        if (other.CompareTag("Player"))
        {
            // Hide or destroy the canvas
            // Example: Hide the canvas
            endScreen.SetActive(true);
        }
    }

}
