using UnityEngine;

public class PauseOnSceneLoad : MonoBehaviour
{
    [SerializeField] private GameObject controlsMenu;
    [SerializeField] private GameObject gameOverMenu;

    public bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke(nameof(PauseGame), 0.5f);
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverMenu.activeSelf)
        {
            Invoke(nameof(PauseGame), 0.1f);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
