using UnityEngine;

public class FreeLookCamera : MonoBehaviour
{
    public float sensitivity = 2.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float rotationY = Input.GetAxis("Mouse X") * sensitivity;
        float rotationX = - Input.GetAxis("Mouse Y") * sensitivity;

        transform.rotation *= Quaternion.Euler(rotationX, rotationY, 0);
    }
}