using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DelayUIEntrance : MonoBehaviour
{
    [SerializeField] private GameObject hintWindow;
    [SerializeField] private GameObject timer;

    [SerializeField] private GameObject hintDialogue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke(nameof(ShowHintWindow), 1.0f);
        Invoke(nameof(ShowTimer), 9.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowHintWindow()
    {
        hintWindow.SetActive(true);
        string hintText = hintDialogue.transform.GetComponent<TypewriterEffectCallerSample>().m_Message;

        hintText = "That's your target, Agent";
        Debug.Log(hintText);
        
    }

    public void ShowTimer()
    {
        timer.SetActive(true);
    }
}
