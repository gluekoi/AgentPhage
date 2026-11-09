using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class Countdown : MonoBehaviour
{
    public float countdown = 60f;
    [SerializeField] private TMP_Text timerTMP;
    [SerializeField] private GameObject gameOverScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(CountingDown), 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        timerTMP.text = countdown + "";
    }

    public void CountingDown()
    {
        //Debug.Log("Testing Countdown");
        countdown -= 1;

        if(countdown == 0)
        {
            CancelInvoke();
            gameOverScreen.SetActive(true);
        }
    }
}
