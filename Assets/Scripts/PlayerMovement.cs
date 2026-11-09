using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private int speed;


    public float movementSpeed;

    public float rotationSpeed;
    private Rigidbody rb;


    private Quaternion targetPos;
    public Vector3 velocity = new Vector3(0, 0, 2);

    [SerializeField]
    bool spedUp = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(PlayerFaster());
      
    }

    // Update is called once per frame
    void Update()
    {
        float movementInput = Input.GetAxis("Horizontal") * movementSpeed;
        float movementInputz = Input.GetAxis("Vertical") * movementSpeed;

        //rb.linearVelocity = new Vector3(movementInput, movementInputz, speed);
        transform.position += transform.forward * (speed * Time.deltaTime);
        Vector3  movementDirection = new Vector3(movementInput, movementInputz, 0);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.Self);

       /* if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            Quaternion currentRot = transform.rotation;
            targetPos = new Quaternion(0, currentRot.y, 0, 1);

        }*/
        
        /*else
        
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetPos, 0.1f);
           

        }
*/
      



       

      
         if (Input.GetKeyDown(KeyCode.Space))

         {
            { 
                if (spedUp == false)

            spedUp = true;
            StartCoroutine(SpeedUp());
            }
         }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Left boundary")
        {
            Debug.Log("left boundary reached");
            transform.Translate(2.0f,0.0f,0.0f, Space.Self);
           
        }
         if (collider.gameObject.name == "Right boundary")
         {
             Debug.Log("right boundary reached");
             transform.Translate(-2.0f,0.0f,0.0f, Space.Self);
         }
          if (collider.gameObject.name == "Top boundary")
         {
             Debug.Log("Top boundary reached");
             transform.Translate(0.0f,-2.0f,00.0f, Space.Self);
         } 
         if (collider.gameObject.name == "Top boundary")
         {
             Debug.Log("Top boundary reached");
             transform.Translate(0.0f,-2.0f,00.0f, Space.Self);
         }
         if (collider.gameObject.name == "Bottom boundary")
         {
             Debug.Log("Bottom boundary reached");
             transform.Translate(0.0f,2.0f,0.0f, Space.Self);
         }
         if (collider.gameObject.name == "RBC")
       {
        StartCoroutine(SlowPlayer());
        Debug.Log("touch");
       }
    }

    
      IEnumerator SlowPlayer()
      {
        speed -= 4;
        Debug.Log("player slowed");
        yield return new WaitForSeconds(2);
        speed += 4;
        Debug.Log("player normal");
      }

      IEnumerator SpeedUp()
      {
        speed += 6;
        Debug.Log("speed up");
        yield return new WaitForSeconds(2);
        speed -= 3;
        yield return new WaitForSeconds(1);
        speed -=3;
        Debug.Log("player normal");

        spedUp = false;

      }

        IEnumerator PlayerFaster()
    {
        yield return new WaitForSeconds(10);
        speed += 2;
        Debug.Log("10 seconds passed");
        yield return new WaitForSeconds(10);
        speed += 2;
        Debug.Log("20 seconds passed");
        yield return new WaitForSeconds(10);
        speed += 2;
        Debug.Log("30 seconds passed");
        yield return new WaitForSeconds(10);
        speed += 2;
        Debug.Log("40 seconds passed");
        yield return new WaitForSeconds(10);
        speed += 2;
        Debug.Log("50 seconds passed");
    }
}