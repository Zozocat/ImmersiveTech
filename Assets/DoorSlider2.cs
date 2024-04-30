using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class DoorSlider2 : MonoBehaviour
{
    [SerializeField] GameObject key;

    public Transform door;

    private bool locked;

    public Vector3 openPosition;

    public float openSpeed = 1f;
    private bool isOpening = false;
    private float moveDistance;


    void Start()
    {
        openPosition = new Vector3(transform.position.x, transform.position.y, 40);

        locked = true;

        moveDistance = Vector3.Distance(door.position, openPosition);
    }

    void Update()
    {
        if (isOpening)
        {
            door.position = Vector3.MoveTowards(door.position, openPosition, openSpeed * Time.deltaTime);
            if (door.position == openPosition)
            {
                isOpening = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key" && locked)
        {
            UnlockDoor();
        }
    }

    private void UnlockDoor()
    {
        isOpening = true;
        locked = false;

        door.GetComponent<BoxCollider>().enabled = false;
        this.GetComponent<Rigidbody>().isKinematic = false;
    }

}