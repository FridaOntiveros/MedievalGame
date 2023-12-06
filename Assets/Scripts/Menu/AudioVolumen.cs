using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolumen : MonoBehaviour
{
    public Slider controlVolumen;
    public GameObject[] audios;

    // Start is called before the first frame update
    private void Start()
    {
        audios = GameObject.FindGameObjectsWithTag("audio");
        controlVolumen.value = PlayerPrefs.GetFloat("volumenSave");
    }

    // Update is called once per frame
    private void Update()
    {
        foreach(GameObject au in audios)
         au.GetComponent<AudioSource>().volume = controlVolumen.value;
    }

    public void guardarVolumen()
    {
        PlayerPrefs.SetFloat("volumenSave", controlVolumen.value);
    }

    
        
    
}
