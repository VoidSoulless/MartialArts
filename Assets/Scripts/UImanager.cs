using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text timeToPlay;
    public MainTest mainTestReference;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToPlay.text = mainTestReference.GetTimeToPlay().ToString();
    }
}
