using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isOpen;
    private bool doorMoving;
    // Vectors used to store temporary movment targets
    private Vector3 startPos;
    private Vector3 endPos;

    //offset from original position used to move the door
    public Vector3 doorMovement;

    // Movement speed in units per second.
    public float speed = 1.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    void Start()
    {
        // Keep a note of the time the movement started.
        startTime = Time.time;
        startPos = transform.position;
        endPos = startPos+doorMovement;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startPos, startPos+doorMovement);
    }

    // Move to the target end position.
    void Update()
    {
        if (transform.hasChanged){
            transform.hasChanged = false;
            doorMoving = true;
        }
        else{
            doorMoving = false;
        }
        SlideDoor(startPos,endPos);
    }
    void SlideDoor(Vector3 sPos,Vector3 ePos){
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(sPos, ePos, fractionOfJourney);
    }
    
    
    public void ToggleDoor(){
        
        if(doorMoving == false){
            startTime = Time.time;
            startPos = transform.position;
            if (isOpen){
                endPos = startPos + doorMovement;
            }
            else
            {
                endPos = startPos - doorMovement;
            }
            isOpen = !isOpen;
        }
    }
}
