using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windows.Kinect;
public class TrackingPointstList  {

    private static TrackingPointstList _instance;
    private Dictionary<JointType, Vector3> _points;

    public static TrackingPointstList GetInstance() {
        if (_instance == null) {
            _instance = new TrackingPointstList();
        }
        return _instance;
    }

    public Vector3 GetPoint(JointType type) {
        if(_points.ContainsKey(type)){
            return _points[type];
        }
        return Vector3.zero;
    }

    private TrackingPointstList() {
        _points = new Dictionary<JointType, Vector3>();
    }

    public void RefreshPoint (JointType type, Vector3 position) {
        if(_points.ContainsKey(type)){
            _points[type] = position;
        } else {
            _points.Add(type, position);
        }
    }

    public void Desc() {
        Debug.Log("Hay " + _points.Count + " Puntos y posiciones");
    }
}
