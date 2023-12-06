using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float speed=15.0f;
    public float speedGiro=10.0f;
    private Rigidbody enemyRb;
    public GameObject player;
    public Animator animacion;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb=GetComponent<Rigidbody>();
        animacion=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, player.transform.position));
        if(Vector3.Distance(transform.position, player.transform.position)<40){
            animacion.SetBool("Walk", true);
            Vector3 lookDirection=(player.transform.position-transform.position).normalized;
            lookDirection.y=0;
            var rotation = Quaternion.LookRotation(lookDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);
            Debug.Log(lookDirection);
            //enemyRb.AddForce(lookDirection*speed);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            //transform.position+=lookDirection*speed*Time.deltaTime;
        }else{
            animacion.SetBool("Walk", false);
        }

        if(Vector3.Distance(transform.position, player.transform.position)<10){
            animacion.SetBool("isNear", true);
        }else{
            animacion.SetBool("isNear", false);
        }
        
     
    }
}
