using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 * This is an improved orbit script based on the MouseOrbitImproved script found
 * on the unity community wiki. It should run smoother then the original version
 * 
 * Modified by Matt on 29th Oct 2024
 * */
 
[AddComponentMenu("Camera-Control/Mouse Camera Drag Orbit with zoom")]

public class MouseCameraDragOrbitWithZoom  : MonoBehaviour
{

    float rotationYAxis = 0.0f;
	float rotationXAxis = 0.0f;

    float velocityX = 0.0f;
	float velocityY = 0.0f;

    private float distance;

    [SerializeField]
    private float orbitSpeed;

    [SerializeField]
    private float yMinLimit;
	[SerializeField]
    private float yMaxLimit ;

    private Vector3 previousMousePos;

    // Start is called before the first frame update
    void Start()
    {
		Vector3 angles = transform.eulerAngles;
		rotationYAxis = angles.y;
		rotationXAxis = angles.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        /***********************************************************************************/
        //Manage Orbit aroudn target obj
        /***********************************************************************************/
        //if (Input.GetMouseButton(0))
        {
            //Simply use Input.mousePositionDelta in Unity 6
            velocityX += orbitSpeed * GetMousePositionDelta(Input.mousePosition).x * 0.02f;
            velocityY += orbitSpeed * GetMousePositionDelta(Input.mousePosition).y * 0.02f;
        }
        rotationYAxis += velocityX;
        rotationXAxis -= velocityY;
        
        //Limit extend of rotation around X axis
        rotationXAxis = ClampAngle(rotationXAxis, yMinLimit, yMaxLimit);
        rotationYAxis = ClampAngle(rotationYAxis, yMinLimit, yMaxLimit);
   
        Quaternion toRotation = Quaternion.Euler(rotationXAxis, rotationYAxis, 0);
        Quaternion rotation = toRotation;

        
        //Assign Pos and Rot to Camera Transform
        transform.rotation = rotation;
 
        //Store Value of Mouse position as previous
        previousMousePos = Input.mousePosition;
    }

    //Calculate Mouse Position Delta (Between Frames)
    Vector3 GetMousePositionDelta(Vector3 mousePos)
    {
        Vector3 mousePositionDelta = mousePos - previousMousePos;
        return mousePositionDelta.normalized;
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


