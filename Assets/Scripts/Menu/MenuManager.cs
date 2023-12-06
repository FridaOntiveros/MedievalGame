using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BottonCredits(){
        SceneManager.LoadScene("Credits");
    }
    public void BottonBack(){
        SceneManager.LoadScene("Menu");
    }
    public void BottonOptions(){
        SceneManager.LoadScene("Options");
    }
    public void BottonStart(){
        SceneManager.LoadScene("Start");
    }
    public void BottonPlay(){
        SceneManager.LoadScene(4);
    }
}
