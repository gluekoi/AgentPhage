using UnityEngine;

public class TitleSceneSwitch : MonoBehaviour
{
    public FadeBetweenScenesScript fadeBetweenScenesScript;
    [SerializeField] private GameObject fadeManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeBetweenScenesScript = fadeManager.GetComponent<FadeBetweenScenesScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchFromTitleToMainGame()
    {
        fadeBetweenScenesScript.DoFade(0.0f, 1.0f, 2.0f, 4.0f);
        //Debug.Log("FUCK IM FADING");
    }
}
