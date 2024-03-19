using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlaneBehavior : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float tiltSpeed = 20f;
    public float maxTiltAngle = 30f;

    void Update()
    {
        // Move the plane forward
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Tilt the plane left or right based on user input
        float horizontalInput = Input.GetAxis("Horizontal");
        float tiltAmount = horizontalInput * tiltSpeed * Time.deltaTime;
        float newZRotation = Mathf.Clamp(transform.rotation.eulerAngles.z + tiltAmount, 
                                          360 - maxTiltAngle, 
                                          360 + maxTiltAngle);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 
                                               transform.rotation.eulerAngles.y, 
                                               newZRotation);
    }
}
