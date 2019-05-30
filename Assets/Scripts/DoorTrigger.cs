using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    public Transform door;
    public Vector3 openedDoor = new Vector3(7.3f, 7.2f, -7.3f);
    public Vector3 closedDoor = new Vector3(7.3f, 3.6f, -7.3f);
    public float openSpeed = 5f;
    public bool openDoor;

    

    private void Update()
    {
        if (openDoor)
        {
            door.position = Vector3.Lerp(door.position, openedDoor, Time.deltaTime * openSpeed);
        }
        else
        {
            door.position = Vector3.Lerp(door.position, closedDoor, Time.deltaTime * openSpeed);
        }
    }

    
    
    // Der "OnTrigger(Collider other)" ist immer der Collider der auf dem GameObject liegt welches das DoorTrigger Script hat
    // Beachten: der Collider auf dem GO muss immer "Is Trigger" auf true haben
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CloseDoor();
        }
    }


    private void CloseDoor()
    {
        openDoor = false;
    }

    private void OpenDoor()
    {
        openDoor = true;
    }
    
    
}
