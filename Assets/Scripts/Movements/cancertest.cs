using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class cancertest : MonoBehaviour
{  
    
    public float speed;

    public GameObject cancer;
    private Rigidbody rb;

    private Vector3 targetPos;

    private float xPos;
    private float yPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();

        /*xPos = Random.Range(1438f, 1513f);
        yPos = Random.Range(102f, 202f);

        targetPos = new Vector3(xPos, yPos, transform.position.z);
        */
    }

    // Update is called once per frame
    void Update()
    {
         rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y , speed);



       // transform.position= Vector3.Lerp(transform.position, targetPos, 0.08f);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
            Debug.Log("YOU CAUGHT CANCER");
        }
    }
}
