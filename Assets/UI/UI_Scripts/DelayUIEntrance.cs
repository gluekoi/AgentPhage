using UnityEngine;

public class DelayUIEntrance : MonoBehaviour
{
    [SerializeField] private GameObject hintWindow;
    [SerializeField] private GameObject timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke(nameof(ShowUIElement), 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowUIElement()
    {
        hintWindow.SetActive(true);
        timer.SetActive(true);
    }
}
