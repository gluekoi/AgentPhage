using UnityEngine;

public class FreeLookCamera : MonoBehaviour
{
    public float RotSpeed = 2.0f;

    public float rotX;
    public float rotY;

    public Transform target;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        rotX += Input.GetAxis("Mouse X") * RotSpeed;
        rotY += Input.GetAxis("Mouse Y") * RotSpeed;

        rotY = Mathf.Clamp(rotY, -35f, 35f);
        rotX = Mathf.Clamp(rotX, -35f, 35f);

        //Camera rotation only allowed if game us not paused
        //Camera.transform.rotation = Quaternion.Euler(-rotY, 0f, 0f);
        transform.rotation = Quaternion.Euler(-rotY, rotX, 0f);
    }

    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}