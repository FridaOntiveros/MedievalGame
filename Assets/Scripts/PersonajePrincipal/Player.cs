using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour{

    private Animator anim;
    

    void Start()
    {
        anim=GetComponent<Animator>();
    }

    void Update()
    {
        Debug.Log("Prueba");
        if(Input.GetKeyDown(KeyCode.Z)){
            anim.SetBool("Golpe", true);
            Debug.Log("Golpe");
        }else{
            anim.SetBool("Golpe", false);
        }
    }

   

}




























/*public class Player : MonoBehaviour
{
    
	private Rigidbody playerRB;
    private Animator playerAnim;
    private GameObject focalPoint;
    
	private float velocityPlayer=10.0f;
	public float jumpForce = 2f; // La fuerza de salto se configura a su gusto
    public float rotationSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
          Transform personaje = transform.Find("Personaje");
          focalPoint = GameObject.Find("Focal Point");
          playerRB=GetComponent<Rigidbody>();
          playerAnim=personaje.GetComponent<Animator>();
          
    }

    // Update is called once per frame
    void Update()
    {


    	float horizontalInput=Input.GetAxis("Horizontal");
    	float verticalInput = Input.GetAxis("Vertical");
        Vector3 movimientoJugador = new Vector3(horizontalInput,0f, verticalInput);
        
        Debug.Log(verticalInput);


        
        if(Input.GetKeyDown(KeyCode.Space)){  // configuracion de tecla de salto con SPACE (podemos cambiar)
            playerAnim.SetTrigger("Jump");
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log(Vector3.up*jumpForce);
        }





        
        if(horizontalInput!=0 || verticalInput!=0){
            
            
            if(movimientoJugador != Vector3.zero){

                if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){

                    playerAnim.SetBool("isRun", true);
                     transform.position=transform.position + movimientoJugador * velocityPlayer * Time.deltaTime;
                }else{
                    playerAnim.SetBool("isRun", false);
                }

                if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
                    playerAnim.SetBool("isRunBack", true);
                     transform.position=transform.position + movimientoJugador * velocityPlayer * Time.deltaTime;
                }else{
                    playerAnim.SetBool("isRunBack", false);
                }
               
            }


            //playerRB.AddForce(focalPoint.transform.forward * verticalInput * velocityPlayer * Time.deltaTime); 
            //playerAnim.SetBool("isRun", true);
            /*if(verticalInput>0){
                
                playerAnim.SetBool("isRunBack", false);
            }else{

                playerAnim.SetBool("isRun", false);
                playerAnim.SetBool("isRunBack", true);

            }
            
        }else{
            playerAnim.SetBool("isRun", false);
            //playerAnim.SetBool("isRunBack", false);
        }

        
        

    }
}

}*/
