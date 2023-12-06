using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsManager : MonoBehaviour
{
    public float tiempoMinimo = 20.0f; // Tiempo mínimo que el objeto permanecerá deshabilitado
    public float tiempoMaximo = 40.0f; // Tiempo máximo que el objeto permanecerá habilitado
    private GameObject objeto;

    // Start is called before the first frame update
    void Start()
    {
        objeto = gameObject;
        // HabilitarDesabilitarAleatoriamente();
        HabilitarObjeto();
    }
 
    // Update is called once per frame
    // void Update()
    // {
    //     HabilitarDesabilitarAleatoriamente();
    // }
 
 
    void HabilitarDesabilitarAleatoriamente()
    {
        // Deshabilitar el objeto y esperar un tiempo aleatorio antes de habilitarlo nuevamente
        //objeto.SetActive(false);
        float tiempoEspera = Random.Range(tiempoMinimo, tiempoMaximo);
        Invoke("HabilitarObjeto", tiempoEspera);
    }
 
    void HabilitarObjeto()
    {
        // Habilitar el objeto y esperar un tiempo aleatorio antes de deshabilitarlo nuevamente
        objeto.SetActive(true);
        float tiempoEspera = Random.Range(tiempoMinimo, tiempoMaximo);
        Invoke("DeshabilitarObjeto", tiempoEspera);
    }
 
    void DeshabilitarObjeto()
    {
        // Deshabilitar el objeto y esperar un tiempo aleatorio antes de habilitarlo nuevamente
        objeto.SetActive(false);
        float tiempoEspera = Random.Range(tiempoMinimo, tiempoMaximo);
        Invoke("HabilitarObjeto", 5f);
    }
}
