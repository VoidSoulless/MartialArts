using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windows.Kinect;
[System.SerializableAttribute]

public class SaveObject 
{
    private static SaveObject _saveObject;

    public static float timeDel = 0f;
    public string playerName;
    public int playerLevel;
    public int playerGold;
    public int playerLives;
    public static Vector3 head1;
    public static Vector3 neck1;
    public static Vector3 shoudelRight1;
    public static Vector3 elbowRight1;
    public static Vector3 handRight1;
    public static Vector3 head2;
    public static Vector3 neck2;
    public static Vector3 shoudelRight2;
    public static Vector3 elbowRight2;
    public static Vector3 handRight2;
    public static Vector3 head3;
    public static Vector3 neck3;
    public static Vector3 shoudelRight3;
    public static Vector3 elbowRight3;
    public static Vector3 handRight3;
    
    void  Update()
    {
        /*if (<BodySourceManager>() == null)
        {
            return;
        }

        _BodyManager = BodySourceManager.GetComponent<BodySourceManager>();
        if (_BodyManager == null)
        {
            return;
        }

        Windows.Kinect.Body[] data = _BodyManager.GetData();
        if (data == null)
        {
            return;
        }

        foreach (var body in data)
        {
            if (body == null)
            {
                continue;
            }

            if (body.IsTracked)
            {
                CameraSpacePoint cameraSpacePoint = body.Joints[Windows.Kinect.JointType.HandLeft].Position;
                colorSpacePoint = kinectSensor.CoordinateMapper.MapCameraPointToColorSpace(cameraSpacePoint);
            }
        }*/
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            timeDel = Time.time;
        }
        if (timeDel != 0f && Time.time >= timeDel)
        {
            SetJoints1();
        }

        if (timeDel != 0f && Time.time >= timeDel + 0.3f)
        {
            SetJoints2();
        }

        if (timeDel != 0f && Time.time >= timeDel + 0.6f)
        {
            SetJoints3();
        }

    }
    
       

public static void SetJoints1()
    {

        /*head1 = body.Joints[Windows.Kinect.JointType.Head].Position;
         neck1 = Kinect.JointType.Neck.position;
         shoudelRight1 = Kinect.JointType.ShoulderRight.position;
         elbowRight1 = Kinect.JointType.ElbowRight.position;
         handRight1 = Kinect.JointType.HandRight.position;
        */
    }
    public static void SetJoints2() 
    {
        /*head2 = Kinect.JointType.Head.position;
        neck2 = Kinect.JointType.Neck.position;
        shoudelRight2 = Kinect.JointType.ShoulderRight.position;
        elbowRight2 = Kinect.JointType.ElbowRight.position;
        handRight2 = Kinect.JointType.HandRight.position;
    */
    }
    public static void SetJoints3() 
    {
        /*
        head3 = Kinect.JointType.Head.position;
        neck3 = Kinect.JointType.Neck.position;
        shoudelRight3 = Kinect.JointType.ShoulderRight.position;
        elbowRight3 = Kinect.JointType.ElbowRight.position;
        handRight3 = Kinect.JointType.HandRight.position;
        */
    }

}
