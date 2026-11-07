using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.Audio.GeneratorInstance;

public class slowdown : MonoBehaviour


{

    [SerializeField]
    float speed = 5f;
    private Rigidbody rb;
    private bool slowedDown = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("boundary"))
        {

            if (slowedDown == false)
            {

                slowedDown = true;
                StartCoroutine(SlowPlayer());
                Debug.Log("touch");
            }

           
        }
        if (other.gameObject.name == "Start")
        {
            StartCoroutine(PlayerFaster());
            Debug.Log("Player start");
        }

    }
    IEnumerator SlowPlayer()
    {
        speed -= 4;
        Debug.Log("player slowed");
        yield return new WaitForSeconds(2);
        speed += 4;
        Debug.Log("player normal");
        slowedDown = false;
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
