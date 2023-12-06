using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampLight : MonoBehaviour
{
    private Light light;

    void Start()
    {
        light = gameObject.GetComponent<Light>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        light.enabled = true;
    }

    private void OnTriggerExit(Collider other){
        light.enabled = false;
    }
}
