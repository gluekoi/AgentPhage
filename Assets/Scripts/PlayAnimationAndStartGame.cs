using System.Collections;
using UnityEngine;

public class PlayAnimationAndStartGame : MonoBehaviour
{
    public Animator IntroAnim;

    public GameObject Player;

    public GameObject TKilla;

    public GameObject Tumor;

    public GameObject CameraAnim;

    public GameObject GameCamera;


    public PlayerMovement playerMovementScript;

    public SmoothFollow tKillaFollowScript;

    public cancertest CancerTestScript;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IntroAnim.Play("CameraMoveAnim");
        playerMovementScript = Player.GetComponent<PlayerMovement>();
        tKillaFollowScript = TKilla.GetComponent<SmoothFollow>();
        CancerTestScript = Tumor.GetComponent<cancertest>();
        StartCoroutine(PlayAnim());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PlayAnim()
    {
        yield return new WaitForSeconds(9);

        Debug.Log("Game Starting");
        playerMovementScript.enabled = true;
        tKillaFollowScript.enabled = true;
        CancerTestScript.enabled = true;

        CameraAnim.gameObject.SetActive(false);
        GameCamera.gameObject.SetActive(true);





    }
}
