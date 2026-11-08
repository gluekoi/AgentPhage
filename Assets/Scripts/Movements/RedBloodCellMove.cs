using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RedBloodCellMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Object myPrefabObj;
    private Rigidbody rb;
    public float speed;

    //speed of rotation
    public float degreesPerSecond = 10.0f;


    [SerializeField]
    int zPos = 10;
    [SerializeField]
    bool creatingRBCs = false;

    [SerializeField]
    GameObject RBC;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        if (creatingRBCs == false)// so segments dont generate at the smae time
        {
            creatingRBCs = true;
            StartCoroutine(RBCGen());
        }
      

        //rotates RBCs
        transform.Rotate(degreesPerSecond * Time.deltaTime, degreesPerSecond * Time.deltaTime, degreesPerSecond * Time.deltaTime);
        rb.linearVelocity = new Vector3(-speed, rb.linearVelocity.y, rb.linearVelocity.z);




    }

    IEnumerator RBCGen() //co-routine, functions dependent on time
    //Ienumerator yield = when to perform another executtion
    {
        //random num generator
        transform.rotation = Random.rotation;
       
        Instantiate(RBC);
        RBC.transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-100.0f + zPos, -90.0f + zPos));

        Instantiate(RBC, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), zPos), Quaternion.identity);


        zPos += 40;
        yield return new WaitForSeconds(2); //wait for 10 seconds before action
        creatingRBCs = false; //restarts function
    }
}