using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windows.Kinect;

public class MainTest : MonoBehaviour
{
    public float dificulty;
  
    private float timeActual=0f;
    float timeToPlay = 0f;
    private Vector3 jointHandLeft1;
    private Vector3 jointHandLeft2;
    private Vector3 jointHandLeft3;
    private Vector3 jointKneeLeft1;
    private Vector3 jointKneeLeft2;
    private Vector3 jointKneeLeft3;
    private Vector3 jointHipLeft1;
    private Vector3 jointHipLeft2;
    private Vector3 jointHipLeft3;
    private Vector3 jointKneeRight1;
    private Vector3 jointKneeRight2;
    private Vector3 jointKneeRight3;
    private Vector3 jointHipRight1;
    private Vector3 jointHipRight2;
    private Vector3 jointHipRight3;
    private Vector3 jointElbowLeft1;
    private Vector3 jointElbowLeft2;
    private Vector3 jointElbowLeft3;
    private Vector3 jointElbowRight1;
    private Vector3 jointElbowRight2;
    private Vector3 jointElbowRight3;
    private Vector3 jointHandRight1;
    private Vector3 jointHandRight2;
    private Vector3 jointHandRight3;

    float directionElbowLeftHandLeft1;
    float directionElbowRightHandRight1;

    float directionKneeLeftHipLeft;
    float directionKneeRightHipRight;

    float directionElbowLeftHandLeft2;
    float directionElbowRightHandRight2;


    public float iDElbowLeftHandLeft1;
    public float iDElbowRightHandRight1;

    public float iDKneeLeftHipLeft;
    public float iDKneeRightHipRight;
   
    public float iDElbowLeftHandLeft2;
    public float iDElbowRightHandRight2;

    bool correctMeBool = true;

    public SoundLoser soundLoserReference;
    public SoundWinner soundWinnerReference;
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            
            BeginPlaying();
            //Invoke("BeginPlaying", 3f);

        }
        if (timeActual != 0f)
        {
            if (Time.time >= (timeActual + 3.3f) && Time.time < (timeActual + 3.318f))
            {
               // Debug.Log("Capture1 nice");
                Capture1();
            }

            if (Time.time >= (timeActual + 3.6f) && Time.time < (timeActual + 3.618f))
            {
              //  Debug.Log("Capture2 nice");
                Capture2();
            }

            if (Time.time >= (timeActual + 3.9f) && Time.time < (timeActual + 3.918f))
            {
               // Debug.Log("Capture3 nice");
                Capture3();
                
            }
            if (Time.time >= (timeActual + 4f) && correctMeBool == true)
            {
                
                CorrectMe();

            }
        }
        
        //Debug.Log(TrackingPointstList.GetInstance().GetPoint(JointType.HandLeft));
    }

    void BeginPlaying()
    {
        correctMeBool = true;
        timeActual = Time.time;
        Debug.Log("space pressed " + timeActual);
    }

    public float GetTimeToPlay()
    {
        
        if(timeActual!=0f)
        {
            timeToPlay = timeActual - Time.time +3;
        }
        if (timeToPlay<0)
        {
            timeToPlay = 0;
        }
        return timeToPlay;
    }

    void Capture1()
    {
        jointHandLeft1 = TrackingPointstList.GetInstance().GetPoint(JointType.HandLeft);
        jointKneeLeft1 = TrackingPointstList.GetInstance().GetPoint(JointType.KneeLeft);
        jointHipLeft1 = TrackingPointstList.GetInstance().GetPoint(JointType.HipLeft);
        jointKneeRight1 = TrackingPointstList.GetInstance().GetPoint(JointType.KneeRight);
        jointHipRight1 = TrackingPointstList.GetInstance().GetPoint(JointType.HipRight);
        jointElbowLeft1 = TrackingPointstList.GetInstance().GetPoint(JointType.ElbowLeft);
        jointElbowRight1 = TrackingPointstList.GetInstance().GetPoint(JointType.ElbowRight);
        jointHandRight1 = TrackingPointstList.GetInstance().GetPoint(JointType.HandRight);
        //( float anguloGrados = Mathf.Rad2Deg * (Mathf.Atan(puntoCosa.y / puntoCosa.x));
        Vector3 elbowLHandL = jointElbowLeft1 - jointHandLeft1;
        directionElbowLeftHandLeft1 = Mathf.Rad2Deg * (Mathf.Atan(elbowLHandL.y / elbowLHandL.x));
        Vector3 elbowRHandR = jointElbowRight1 - jointHandRight1;
        directionElbowRightHandRight1 = Mathf.Rad2Deg * (Mathf.Atan(elbowRHandR.y / elbowRHandR.x));
       //Debug.Log("POSE1: La dirección Mano izquierda-Codo izquierdo es: " + directionElbowLeftHandLeft1);
       //Debug.Log("POSE1: La dirección Mano derecha-Codo derecha es: " + directionElbowRightHandRight1);

    }
    void Capture2()
    {
        jointHandLeft2 = TrackingPointstList.GetInstance().GetPoint(JointType.HandLeft);
        jointKneeLeft2 = TrackingPointstList.GetInstance().GetPoint(JointType.KneeLeft);
        jointHipLeft2 = TrackingPointstList.GetInstance().GetPoint(JointType.HipLeft);
        jointKneeRight2 = TrackingPointstList.GetInstance().GetPoint(JointType.KneeRight);
        jointHipRight2 = TrackingPointstList.GetInstance().GetPoint(JointType.HipRight);
        jointElbowLeft2 = TrackingPointstList.GetInstance().GetPoint(JointType.ElbowLeft);
        jointElbowRight2 = TrackingPointstList.GetInstance().GetPoint(JointType.ElbowRight);
        jointHandRight2 = TrackingPointstList.GetInstance().GetPoint(JointType.HandRight);
        Vector3 kneeLHipL = jointKneeLeft2 - jointHipLeft2;
        directionKneeLeftHipLeft = Mathf.Rad2Deg * (Mathf.Atan(kneeLHipL.y / kneeLHipL.x));
        Vector3 kneeRHipR = jointKneeRight2 - jointHipRight2;
        directionKneeRightHipRight = Mathf.Rad2Deg * (Mathf.Atan(kneeRHipR.y / kneeRHipR.x));
       //Debug.Log("POSE2: La dirección Rodilla izquierda-cadera izquierda es: " + directionKneeLeftHipLeft);
       //Debug.Log("POSE2: La dirección Rodilla derecha-cadera derecha es: " + directionKneeRightHipRight);
    }
    void Capture3()
    {
        jointHandLeft3 = TrackingPointstList.GetInstance().GetPoint(JointType.HandLeft);
        jointKneeLeft3 = TrackingPointstList.GetInstance().GetPoint(JointType.KneeLeft);
        jointHipLeft3 = TrackingPointstList.GetInstance().GetPoint(JointType.HipLeft);
        jointKneeRight3 = TrackingPointstList.GetInstance().GetPoint(JointType.KneeRight);
        jointHipRight3 = TrackingPointstList.GetInstance().GetPoint(JointType.HipRight);
        jointElbowLeft3 = TrackingPointstList.GetInstance().GetPoint(JointType.ElbowLeft);
        jointElbowRight3 = TrackingPointstList.GetInstance().GetPoint(JointType.ElbowRight);
        jointHandRight3 = TrackingPointstList.GetInstance().GetPoint(JointType.HandRight);
        Vector3 kneeLHipL2 = jointHandLeft3 - jointElbowLeft3;
        directionElbowLeftHandLeft2 = Mathf.Rad2Deg * (Mathf.Atan(kneeLHipL2.y / kneeLHipL2.x));
        Vector3 kneeRHipR2 = jointHandRight3 - jointElbowRight3;
        directionElbowRightHandRight2 = Mathf.Rad2Deg * (Mathf.Atan(kneeRHipR2.y / kneeRHipR2.x));
       //Debug.Log("POSE3: La dirección Mano izquierda-Codo izquierda es: " + directionElbowLeftHandLeft2);
       //Debug.Log("POSE3: La dirección Mano derecha-Codo derecha es: " + directionElbowRightHandRight2);
    }
    void CorrectMe()
    {
        float correctedElbowLHandL1 = Mathf.Abs(-directionElbowLeftHandLeft1);
        float correctedElbowRHandR1 = Mathf.Abs(-directionElbowRightHandRight1);
        float correctedKneeLHipL = Mathf.Abs(-directionKneeLeftHipLeft); 
        float correctedKneeRHipR = Mathf.Abs(-directionKneeRightHipRight);
        float correctedElbowLHandL2 = Mathf.Abs(-directionElbowLeftHandLeft2); 
        float correctedElbowRHandR2 = Mathf.Abs(-directionElbowRightHandRight2); 

        Debug.Log(correctedElbowLHandL1);
        Debug.Log(correctedElbowRHandR1);
        Debug.Log(correctedKneeLHipL);
        Debug.Log(correctedKneeRHipR);
        Debug.Log(correctedElbowLHandL2);
        Debug.Log(correctedElbowRHandR2);
        bool p1WellDone1;
        bool p1WellDone2;
        bool p2WellDone1;
        bool p2WellDone2;
        bool p3WellDone1;
        bool p3WellDone2;
        correctMeBool = false;
        if (correctedElbowLHandL1 > (iDElbowLeftHandLeft1 - dificulty) && correctedElbowLHandL1 < (iDElbowLeftHandLeft1 + dificulty))
        {
            Debug.Log("POSE1: La dirección Mano izquierda-Codo izquierdo es correcta");
            p1WellDone1 = true;
        }
        else
        {
            Debug.Log("POSE1: La dirección Mano izquierda-Codo izquierdo es incorrecta");
            p1WellDone1 = false;
        }

        if (correctedElbowRHandR1 > (iDElbowRightHandRight1 - dificulty) && correctedElbowRHandR1 < (iDElbowRightHandRight1 + dificulty))
        {
            Debug.Log("POSE1: La dirección Mano derecha-Codo derecho es correcta");
            p1WellDone2 = true;
        }
        else
        {
            Debug.Log("POSE1: La dirección Mano derecha-Codo derecho incorrecta");
            p1WellDone2 = false;
        }

        if (correctedKneeLHipL > (iDKneeLeftHipLeft - dificulty) && correctedKneeLHipL < (iDKneeLeftHipLeft + dificulty))
        {
            Debug.Log("POSE2: La dirección Rodilla izquierda-cadera izquierda es correcta");
            p2WellDone1 = true;
        }
        else
        {
            Debug.Log("POSE2: La dirección Rodilla izquierda-cadera izquierda es incorrecta");
            p2WellDone1 = false;
        }

        if (correctedKneeRHipR > (iDKneeRightHipRight - dificulty) && correctedKneeRHipR < (iDKneeRightHipRight + dificulty))
        {
            Debug.Log("POSE2: La dirección Rodilla derecha-cadera derecha es correcta");
            p2WellDone2 = true;
        }
        else
        {
            Debug.Log("POSE2: La dirección Rodilla derecha-cadera derecha es es incorrecta");
            p2WellDone2 = false;
        }

        if (correctedElbowLHandL2 > (iDElbowLeftHandLeft2 - dificulty) && correctedElbowLHandL2 < (iDElbowLeftHandLeft2 + dificulty))
        {
            Debug.Log("POSE3: La dirección Mano izquierda-Codo izquierda es correcta");
            p3WellDone1 = true;
        }
        else
        {
            Debug.Log("POSE3: La dirección Mano izquierda-Codo izquierda es incorrecta");
            p3WellDone1 = false;
        }

        if (correctedElbowRHandR2 > (iDElbowRightHandRight2 - dificulty) && correctedElbowRHandR2 < (iDElbowRightHandRight2 + dificulty))
        {
            Debug.Log("POSE3: La dirección Mano derecha-Codo derecha es correcta");
            p3WellDone2 = true;
        }
        else
        {
            Debug.Log("POSE3: La dirección Mano derecha-Codo derecha es incorrecta");
            p3WellDone2 = false;
        }

        if((p1WellDone1 == true) && (p1WellDone2 == true) && (p2WellDone1 == true) && (p2WellDone2 == true) && (p3WellDone1 == true) && (p3WellDone2 == true))
        {
            soundWinnerReference.PlayWinSound();
            Debug.Log("Bien hecho");
        }
        else
        {
            soundLoserReference.PlayLossSound();
            Debug.Log("Suerte la proxima");
        }
    }    
}
