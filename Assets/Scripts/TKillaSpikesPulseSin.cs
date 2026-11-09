using UnityEngine;

public class TKillaSpikesPulseSin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(Mathf.Sin(Time.time)/4 + 1, Mathf.Sin(Time.time)/4 + 1, Mathf.Sin(Time.time)/4 + 1);

        transform.localScale = vec;
    }
}

