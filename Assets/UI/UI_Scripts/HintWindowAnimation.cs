using UnityEngine;

public class HintWindowAnimation : MonoBehaviour
{
    [SerializeField] private CanvasGroup hintWindowCanvas;

    [SerializeField] private Animator anim;
    [SerializeField] private GameObject hintWindow;

    private string hideHint = "HintWindowExitAnim";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = hintWindow.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hintWindowCanvas.alpha == 1)
        {
            Invoke(nameof(HideHintWindow), 5f);
        }
        else
        {
            CancelInvoke();
        }
    }

    void HideHintWindow()
    {
        Debug.Log("I should be hiding now");
        anim.Play(hideHint, 0, 0.0f);
        CancelInvoke();
    }
}
