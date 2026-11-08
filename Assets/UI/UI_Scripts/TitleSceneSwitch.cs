using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneSwitch : MonoBehaviour
{
    public FadeBetweenScenesScript fadeBetweenScenesScript;
    [SerializeField] private GameObject fadeManager;
    [SerializeField] private float startAlpha;
    [SerializeField] private float endAlpha;
    [SerializeField] private float duration;
    [SerializeField] private float delayBeforeFade;

    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    [SerializeField] private int sceneNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeBetweenScenesScript = fadeManager.GetComponent<FadeBetweenScenesScript>();
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/Scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScenes()
    {
        fadeBetweenScenesScript.DoFade(startAlpha, endAlpha, duration, delayBeforeFade);
        //Debug.Log("FUCK IM FADING");
        Invoke(nameof(LoadNextScene), duration + delayBeforeFade);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(scenePaths[sceneNumber]);
    }
}
