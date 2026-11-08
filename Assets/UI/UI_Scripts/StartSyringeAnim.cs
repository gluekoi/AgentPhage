using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class StartSyringeAnim : MonoBehaviour
{
    [SerializeField] GameObject syringeAnim;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Animator cameraAnim;

    private string inject = "CameraMoveAnim";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*for (int i = 0; i < syringeAnim.transform.childCount; i++)
        {
            if (syringeAnim.transform.GetChild(i).gameObject.GetComponent<Animator>() != null)
            {
                syringeAnim.transform.GetChild(i).gameObject.GetComponent<Animator>().enabled = false;
            }
            
        }*/

        //mainCamera.transform.GetComponent<Animator>().enabled = false;
        cameraAnim = mainCamera.transform.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableSyringeAnim()
    {
        /*for (int i = 0; i < syringeAnim.transform.childCount; i++)
        {
            if (syringeAnim.transform.GetChild(i).gameObject.GetComponent<Animator>() != null)
            {
                syringeAnim.transform.GetChild(i).gameObject.GetComponent<Animator>().enabled = true;
            }
            
        }*/
        //mainCamera.transform.GetComponent<Animator>().enabled = true;
        cameraAnim.Play(inject, 0, 0.0f);
    }
}
