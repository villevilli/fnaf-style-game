using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Random;

public class LightFlicker : MonoBehaviour
{
    public Light light;
    public float flickerOnTime;
    public float flickerOffTime;
    // Start is called before the first frame update
    void Start(){
        StartCoroutine (LightFlickerTimer());
    }

    IEnumerator LightFlickerTimer(){
        while (true){
            light.enabled = false;   
            yield return new WaitForSeconds(Random.Range(0,flickerOffTime));
            light.enabled = true; 
            yield return new WaitForSeconds(Random.Range(0,flickerOnTime));
        }
    }
}
