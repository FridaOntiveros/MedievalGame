using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaculos : MonoBehaviour
{
        public Transform puntoInicio;
        private CharacterController characterController;
        private Animator animacion;
    
    // Start is called before the first frame update
    void Start()
    {
         characterController = GetComponent<CharacterController>();
         animacion = GetComponent<Animator>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -21.1f)
        {
            
            SceneManager.LoadScene("Puente2");
        }
    }

 

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
       
        GameObject objetoColisionado = hit.collider.gameObject;

        if (objetoColisionado.tag == "Obstaculo" || objetoColisionado.tag == "Arma")
        {
            
            Debug.Log("StartedCoroutine");
            animacion.SetBool("Dead", true);
            characterController.enabled=false;
            StartCoroutine(PauseGame());
            
            
        }

        if(objetoColisionado.tag == "PuertaSalida" ){
            SceneManager.LoadScene("Win");
        }
    }

    IEnumerator PauseGame(){
        
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Puente2");

    }
}
