using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titulo : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] private GameObject titulo;
    void Start()
    {
        LeanTween.moveX(titulo.GetComponent<RectTransform>(),-370,1.5f).setDelay(2.0f).setEase(LeanTweenType.easeOutBounce);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

}
