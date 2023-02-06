using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
 {
    public bool isActive;
    //public GameObject fadeEffect;

    private void Start()
    {
        isActive = false;
    }

   
    public void SwitchScene(string name)
    {
        SceneManager.LoadScene(name);
        isActive = true;
        
    }
}
 