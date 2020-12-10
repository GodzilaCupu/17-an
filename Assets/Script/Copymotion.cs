using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copymotion : MonoBehaviour
{
    public Transform targetLimb;
    ConfigurableJoint joint;


    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

    }

    // Update is called once per frame
    void Update()
    {
        joint.targetRotation = targetLimb.rotation;
    }
}
