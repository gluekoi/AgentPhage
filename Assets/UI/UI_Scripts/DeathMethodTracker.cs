using UnityEngine;

public class DeathMethodTracker : MonoBehaviour
{
    //need to track death by countdown & t-killa
    //need to track death number (link to integer via retry at pause screen?)
    //need to change scientist message appropriately

    [SerializeField] private GameObject mainMenuManager;
    public Countdown countdownScript;

    [SerializeField] private GameObject typewriterEffectManager;
    public TypewriterEffectCallerSample typewriterMessageBox;

    [SerializeField] private GameObject gameOverScreen;

    public bool countdownReachZero = false;

    public int deathCounter = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        countdownScript = mainMenuManager.GetComponent<Countdown>();
        typewriterMessageBox = typewriterEffectManager.GetComponent<TypewriterEffectCallerSample>();
        countdownReachZero = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownScript.countdown == 0)
        {
            if (!countdownReachZero)
            {
                countdownReachZero = true;
                DeathByTime();
            }
    
        }
    }

    void DeathByTime()
    {
        Debug.Log("Time comes for us all");
        gameOverScreen.SetActive(true);
        deathCounter += 1;
        typewriterMessageBox.m_Message = "Deploying Agent Phage " + deathCounter + "." + "Remember, Agent, you only have so much time to get to that cell!";
    }

    void DeathByTKilla()
    {
        Debug.Log("Curse that TKilla!");
        gameOverScreen.SetActive(true);
        deathCounter += 1;
        typewriterMessageBox.m_Message = "Drat! Your predecessor was endocytosed by T-Killa, Agent Phage " + deathCounter + ". We used to be good friends until.. well... anyways! Keep your focus on the mission, Agent, and avoid getting caught by T-Killa!"; 
    }
}
