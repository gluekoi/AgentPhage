using UnityEngine;


public class RotatePhage : MonoBehaviour
{

    public GameObject phage;

    //Vector3 rotateBy = new Vector3(0,90,0, Space.Self); 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //transform.Rotate(rotateBy * Time.deltaTime); 
    //Debug.Log(transform.position);

    transform.Rotate(30 * Time.deltaTime, 0 , 0, Space.Self);
    }
}
