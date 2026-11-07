using UnityEngine;

public class RedBloodCellMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Object myPrefabObj;
    private Rigidbody rb;
    public float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject obj;

       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //obj = (GameObject)Instantiate(myPrefabObj); 
            //obj.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            //rb.linearVelocity = new Vector3(-speed, rb.linearVelocity.y, rb.linearVelocity.z);
        }  
        
    }
}
