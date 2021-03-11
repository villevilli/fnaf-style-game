using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButtonController : MonoBehaviour
{
    public Light buttonTarget;
    bool lightOn;
    void Start(){
        buttonTarget.enabled = false;
    }
    void OnMouseDown(){
        buttonTarget.enabled = true;
    }
    void OnMouseUp(){
        buttonTarget.enabled = false;
    }
}