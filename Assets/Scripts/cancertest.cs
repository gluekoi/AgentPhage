using UnityEngine;
using TMPro;

public class cancertest : MonoBehaviour
{  
    
    public float speed;
 private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y , speed);
    }
}
