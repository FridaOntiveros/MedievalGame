using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class Calidad : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Dropdown dropdown;
    public int calidad;
    void Start()
    {
        calidad = PlayerPrefs.GetInt("numeroDeCalidad");
        dropdown.value = calidad;
        AjustarCalidad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", dropdown.value);
        calidad=dropdown.value;
    }


}
