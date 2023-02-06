using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareJoints : MonoBehaviour
{
    public Vector3 userHead;
    public Vector3 userNeck;
    public Vector3 userRightHand;
    private float coeficienteDeDificultad = 0.2f;
    private float coeficienteDeAltura = 0.10f;
    
    void Start()
    {
        
    }

    void Update()
    {
        /*if (((SaveObject.head1.transform.position - userHead.transform.position).magnitude)/coeficienteDeAltura > coeficienteDeDificultad){
            Debug.Log("Mueve tu cabeza bien, manco");
        }
        
        else{
            Debug.Log("Al menos tu cabeza está pegada");
        }*/

    }
}
