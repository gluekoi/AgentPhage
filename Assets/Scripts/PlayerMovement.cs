using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float movementSpeed;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementInput = Input.GetAxis("Horizontal") * movementSpeed;
        float movementInputz = Input.GetAxis("Vertical") * movementSpeed;
        rb.linearVelocity = new Vector3(-speed, movementInputz, movementInput);
    }
}
