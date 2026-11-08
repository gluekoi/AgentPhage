using UnityEngine;

public class Tumour3PulseSin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(Mathf.Sin(Time.time) /8 + 0.5f, Mathf.Sin(Time.time) /8 + 0.5f, Mathf.Sin(Time.time) /8 + 0.5f);

        transform.localScale = vec;
    }
}
