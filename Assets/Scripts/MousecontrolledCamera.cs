using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MousecontrolledCamera : MonoBehaviour
{
    public float rotationX = 0f;
    public float rotationY = 0f;

    public float Msensitivity = 1f;



    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }


    // Update is called once per frame
    void Update()
    {
       rotationY = Input.GetAxis("Mouse X") *  Msensitivity;
       rotationX = - Input.GetAxis("Mouse Y") *  Msensitivity;
        //transform.Rotate(Vector3.right, rotationY);
        //transform.Rotate(Vector3.up, rotationX, Space.Self);
        transform.rotation *= Quaternion.Euler(rotationX, rotationY, 0);
        rotationX = Mathf.Clamp(rotationX, -35.0f, 35.0f);
        rotationY = Mathf.Clamp(rotationY, -35.0f, 35.0f);

        //transform.eulerAngles = new Vector3(rotationX, rotationY, 0.0f);


        /*transform.localRotation = Quaternion.Euler(ClampAngle(transform.localEulerAngles.x + rotationX, -45.0f,45.0f),
                                            ClampAngle(transform.localEulerAngles.y + rotationY, -45.0f,45.0f),      
                                            transform.localEulerAngles.z);*/
    }

    	// Clamp angle make sure the orbit does not flip the object upside down
	float ClampAngle(float angle, float min, float max)
	{
		if (angle < -360F)
			angle += 360F;
		if (angle > 360F)
			angle -= 360F;
		return Mathf.Clamp(angle, min, max);
	}
}
