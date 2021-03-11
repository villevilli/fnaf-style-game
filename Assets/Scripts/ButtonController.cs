using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject buttonTarget;
    private DoorController doorScript;
    void Start(){
       doorScript = buttonTarget.GetComponent<DoorController>();
    }

    void OnMouseDown(){
        doorScript.ToggleDoor();
    }
}
