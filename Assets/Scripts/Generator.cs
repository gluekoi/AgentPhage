using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generator : MonoBehaviour
{
    public GameObject[] vessels;
    

    [SerializeField]
    int zPos = 10;
    [SerializeField]
    bool creatingSegment = false;
    [SerializeField]
    int segmentNum;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()//continously generate new segments
    {
        if(creatingSegment == false)// so segments dont generate at the smae time
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }
       
    }

    IEnumerator SegmentGen() //co-routine, functions dependent on time
    //Ienumerator yield = when to perform another executtion
    {
        //random num generator
        segmentNum = Random.Range(0, 3);
        Instantiate(vessels[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(3); //wait for 10 seconds before action
        creatingSegment = false; //restarts function
    }

   
}
