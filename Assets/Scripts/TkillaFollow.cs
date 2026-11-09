using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class SmoothFollow : MonoBehaviour 
{ 
   [SerializeField]
 private GameObject target;


 public float rotationSpeed = 3f;

 private Quaternion lookRotation;

 private Vector3 directionTarget;

 private Vector3 movement;

 [SerializeField]
 private int speed = 1;


public Rigidbody rb;
 
   
    void Start()
    {
       
    }
    void Update() 
    { 
      directionTarget = (target.transform.position - transform.position).normalized;
      lookRotation = Quaternion.LookRotation(directionTarget);
      transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
      transform.eulerAngles = new Vector3(0, 0, 0);

      movement = transform.forward * speed;

      rb.linearVelocity = new Vector3(movement.x, movement.y, movement.z);

       
    } 

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
            Debug.Log("touchies and died");
        }
        if (other.gameObject.name == "Start")
        {
            StartCoroutine(TFaster());
            Debug.Log("Tkilla start");
        }
    }
    IEnumerator TFaster()
    {
        yield return new WaitForSeconds(10);
        speed += 2;
        yield return new WaitForSeconds(10);
        speed += 2;
        yield return new WaitForSeconds(10);
        speed += 2;
        yield return new WaitForSeconds(10);
        speed += 2;
        yield return new WaitForSeconds(10);
        speed += 2;
    }



} 