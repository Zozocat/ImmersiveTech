using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public string nextSceneName; // Assign the name of the scene you want to load in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("End triggered");
            SceneManager.LoadScene(nextSceneName); // Load the specified scene
        }
    }

}
