using UnityEngine;

public class TKillaSpikesPulse : MonoBehaviour


{
    private float fScaleTime;
    public float scaleTime
    {
        get
        {
            if (fScaleTime == 0f)
            {
                return 0f;
            }
            else
            {
                return 1.0f / fScaleTime;
            }
        }
        set
        {
            if (value == 0f)
            {
                fScaleTime = 0f;
            }
            else
            {
                fScaleTime = 1.0f / value;
            }
        }
    }

    // An editor-facing initial value, since the property would be hidden in the Inspector
    [SerializeField]
    private float initialScaleTime = 5.0f;

    public Vector3 startingScale = Vector3.one * 1f;
    public Vector3 endingScale = Vector3.one * 2f;

    private float lerpT = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set the property to the Inspector value
        scaleTime = initialScaleTime;
        // Redundant in Start() in this case, but included for general context
        lerpT = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        // Simple example, no conditions involved for this
        transform.localScale = Vector3.Lerp(startingScale, endingScale, lerpT * fScaleTime);
        lerpT += Time.deltaTime;

        //*Vector3 vec = new Vector3(Mathf.Sin(Time.time) + 1, Mathf.Sin(Time.time) + 1, Mathf.Sin(Time.time) + 1);

        // *transform.localScale = vec;
    }
}
