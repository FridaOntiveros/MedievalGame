using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class diapositiva : MonoBehaviour
{
    public Transform[] elementos;
    public float velocidad;
    public int indice=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector3.Lerp(transform.position, elementos[indice].position, velocidad*Time.deltaTime);
        transform.rotation=Quaternion.Lerp(transform.rotation,elementos[indice].rotation, velocidad*Time.deltaTime*.5f);
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            indice = (indice+1)%elementos.Length;
         }else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            indice --;
            if(indice< 0)
            {
                indice = elementos.Length-1;
            }
         }
    }
}
