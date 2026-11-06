using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlsMenuKeyboard : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject keyButton;
    private string pressW = "ControlsWAnim";
    private string pressA = "ControlsAAnim";
    private string pressS = "ControlsSAnim";
    private string pressD = "ControlsDAnim";
    private string pressSpace = "ControlsSpaceAnim";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = keyButton.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.Play(pressW, 0, 0.0f);
            this.keyButton.transform.GetChild(0).gameObject.SetActive(true);
            this.keyButton.transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.Play(pressW, 0, 0.0f);
            this.keyButton.transform.GetChild(0).gameObject.SetActive(false);
            this.keyButton.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.Play(pressA, 0, 0.0f);
            this.keyButton.transform.GetChild(0).gameObject.SetActive(true);
            this.keyButton.transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.Play(pressA, 0, 0.0f);
            this.keyButton.transform.GetChild(0).gameObject.SetActive(false);
            this.keyButton.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.Play(pressS, 0, 0.0f);
            this.keyButton.transform.GetChild(0).gameObject.SetActive(true);
            this.keyButton.transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.Play(pressS, 0, 0.0f);
            this.keyButton.transform.GetChild(0).gameObject.SetActive(false);
            this.keyButton.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.Play(pressD, 0, 0.0f);
            this.keyButton.transform.GetChild(0).gameObject.SetActive(true);
            this.keyButton.transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.Play(pressD, 0, 0.0f);
            this.keyButton.transform.GetChild(0).gameObject.SetActive(false);
            this.keyButton.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play(pressSpace, 0, 0.0f);
        }

    }

}
