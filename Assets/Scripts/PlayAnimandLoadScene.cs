using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayAnimandLoadScene : MonoBehaviour
{

    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator.Play("GameIntro");
        StartCoroutine(LoadScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(9);
        SceneManager.LoadScene(1);
        Debug.Log("Loading Game Scene");
    }
}
