using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Camera cam;
    public Light roomLight;
    public GameObject player;
    public float turnSpeed;
    void Start()
    {
        cam = GetComponent<Camera>();
    }
    void Update()
    {
        float rotInput = Input.GetAxis("Horizontal");
        if (player.transform.eulerAngles.y > 70 && player.transform.eulerAngles.y < 80){
            rotInput = Mathf.Clamp(rotInput,-1,0);
        }
        

        if (player.transform.eulerAngles.y < 290 && player.transform.eulerAngles.y > 280){
            rotInput = Mathf.Clamp(rotInput,0,1);
        }

        player.transform.Rotate(0,rotInput*turnSpeed,0);
        
        if (Input.GetButtonDown("Fire1")){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit,20)) {
                //print("hit");
            }
        }
        

    }
}
