using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlider : MonoBehaviour
{
    //[SerializeField] GameObject door;
    [SerializeField] GameObject key;

    private bool locked;

    public Transform door; // Assign the part of the door that should move.
    public Vector3 openPosition; // Set this to the position the door should slide to.
    public float openSpeed = 1f; // Speed at which the door opens.
    public float OpenDuration { get; private set; } // The estimated time it takes for the door to open completely.

    private bool isOpening = false;
    private float moveDistance;


    void Start()
    {
        openPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        locked = true;
        door.GetComponent<Rigidbody>().isKinematic = true;
        door.GetComponent<BoxCollider>().enabled = true;

        moveDistance = Vector3.Distance(door.position, openPosition);
        OpenDuration = moveDistance / openSpeed; // Calculate the duration it takes to open the door.
    }

    void Update()
    {
        if (isOpening)
        {
            Debug.Log("Door opening");

            door.position = Vector3.MoveTowards(door.position, openPosition, openSpeed * Time.deltaTime);
            if (door.position == openPosition)
            {
                isOpening = false; // Stops the door from further movement once it's open.
            }
        }
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
        isOpening = true;
        Debug.Log("Door unlocked");
        door.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<Rigidbody>().isKinematic = false;
        door.GetComponent<BoxCollider>().enabled = false;
        locked = false;
    }

    private void LockDoor()
    {
        isOpening = false;
        Debug.Log("Door locked");
        door.GetComponent<Rigidbody>().isKinematic = true;
        this.GetComponent<Rigidbody>().isKinematic = true;
        locked = true;
    }
}