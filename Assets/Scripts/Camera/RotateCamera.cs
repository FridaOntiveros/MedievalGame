using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
	 public Transform objetivo;
    public float suavizado = 5f; // Ajusta esto para cambiar la suavidad del seguimiento
    private Vector3 distancia;
     public Vector3 offset = new Vector3(0f, 3f, -7f);
    void LateUpdate()
    {
        if (objetivo != null)
        {
        	distancia=new Vector3(transform.position.x, transform.position.y-5, transform.position.z+30);
            // Calcula la posición deseada de la cámara
            Vector3 posicionDeseada = objetivo.position+offset;
            // Aplica el suavizado para un seguimiento más suave
            transform.position = Vector3.Lerp(transform.position, posicionDeseada-distancia, suavizado * Time.fixedDeltaTime);
            // La cámara siempre mira hacia el jugador
            transform.LookAt(objetivo);
        }
    }
}
