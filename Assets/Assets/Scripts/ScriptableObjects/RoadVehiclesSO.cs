using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class RoadVehiclesSO : ScriptableObject {
    public string vehicleName;
    public float speed;
    public float stopTimeWhenHit;
    public float speedIncreaseAfterHit;
    public int pointsWhenHit;
    public GameObject vehiclePrefab;
    public Quaternion rotationAdjustment;
}
