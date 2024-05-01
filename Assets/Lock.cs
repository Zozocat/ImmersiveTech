using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject key;

    private bool locked;

    void Start()
    {
        locked = true;
        door.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key" && locked)
        {
            Debug.Log("Door will unlock");
            UnlockDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Key" && !locked)
        {
            Debug.Log("Door will lock");
            LockDoor();
        }
    }

    private void UnlockDoor()
    {
        Debug.Log("Door unlocked");
        door.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<Rigidbody>().isKinematic = false;
        locked = false;
    }

    private void LockDoor()
    {
        Debug.Log("Door locked");
        door.GetComponent<Rigidbody>().isKinematic = true;
        this.GetComponent<Rigidbody>().isKinematic = true;
        locked = true;
    }
}

//AI was used to help write this script