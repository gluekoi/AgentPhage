using UnityEngine;

public class RotatePhage : MonoBehaviour
{

    Vector3 rotateBy = new Vector3(0,90,0); 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.Rotate(rotateBy * Time.deltaTime); 
    Debug.Log(transform.position);
    }
}
