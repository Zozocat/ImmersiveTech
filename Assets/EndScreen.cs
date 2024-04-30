using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public Canvas myCanvas; // Reference to your canvas (either directly or via tag)

    // Example: Enable the canvas when a trigger event occurs
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("End")) // Replace "Player" with your desired tag
        {
            myCanvas.enabled = true;
        }
    }
}
