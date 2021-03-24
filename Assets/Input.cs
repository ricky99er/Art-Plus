using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
public class Input : MonoBehaviour
{
    public gameObject Camera mOffset
    
    // Update is called once per frame
    void Update()
    {
        Vector2 input = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstickl);
        Vector3 movement = camera.transform.TransformDirection(input.x, 0, input.y);
        movement.y = 0;
        movement = movement.magnitude == 0 ? Vector3.zero : movement / movement.magnitude;
        
    }
}
