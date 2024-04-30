using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public Canvas myCanvas; // Reference to your canvas GameObject

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Replace "Player" with your desired tag
        {
            myCanvas.enabled = true;
        }
    }

        private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myCanvas.enabled = false;
        }
    }
}
