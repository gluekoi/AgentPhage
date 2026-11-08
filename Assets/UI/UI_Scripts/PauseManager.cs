using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    public bool isPaused = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isPaused)
            {
                isPaused = true;
                PauseGame();
                pauseMenu.SetActive(true);
            }
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
