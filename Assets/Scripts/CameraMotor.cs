using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;

    private Vector3 desiredPosition;
    private Vector3 offset;
    public float smoothSpeed = 7.5f;
    public float distance = 10.0f;
    public float yOffset = 3.5f;

    private void Start()
    {
        offset = new Vector3 (0, yOffset, -1f * distance);
    }
    private void Update() 
    {
        if (Input.GetKeyDown (KeyCode.D))
        {
            SlideCamera (true);
        }
        else if (Input.GetKeyDown (KeyCode.A))
        {
            SlideCamera (false);
        }
        
    }
    private void FixedUpdate() 
    {
        desiredPosition = lookAt.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt (lookAt.position + Vector3.up);
    }

    public void SlideCamera(bool left)
    {
        if(left)
        {
            offset = Quaternion.Euler (0, 15, 0) * offset;
        }
        else
        {
            offset = Quaternion.Euler (0, -15, 0) * offset;
        }
    }

}
