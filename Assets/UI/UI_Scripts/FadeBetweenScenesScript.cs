using System;
using System.Collections;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FadeBetweenScenesScript : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image fadeImage;
    [SerializeField] private CanvasGroup fadeImageCanvas;
    [SerializeField] private bool automaticallyFadeInOnSceneLoad;
    private Coroutine fadeCoroutine;
    [SerializeField] private float automaticFadeStartAlpha;
    [SerializeField] private float automaticFadeEndAlpha;
    [SerializeField] private float automaticFadeDuration;
    [SerializeField] private float automaticFadeDelayBeforeFade;

    void Awake()
    {
        if (automaticallyFadeInOnSceneLoad)
        {
            DoFade(automaticFadeStartAlpha, automaticFadeEndAlpha, automaticFadeDuration, automaticFadeDelayBeforeFade);
        }
        
    }

    public void DoFade(float startAlpha, float endAlpha, float duration, float delayBeforeFade)
    {
        if(fadeCoroutine != null)
        {
            StopCoroutine(fadeCoroutine);
        }

        fadeCoroutine = StartCoroutine(AniamteFade(startAlpha, endAlpha, duration, delayBeforeFade));
    }

    private IEnumerator AniamteFade(float startAlpha, float endAlpha, float duration, float delayBeforeFade)
    {
        fadeImage.enabled = true;
        fadeImageCanvas.alpha = startAlpha;
        yield return null;

        yield return new WaitForSeconds(delayBeforeFade);
        float timeElapsed = 0;
        while (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime;
            float fadePercentage = timeElapsed/duration;
            fadePercentage = Mathf.Clamp01(fadePercentage); //percentage is clamped between 0 and 1
            fadeImageCanvas.alpha = Mathf.Lerp(startAlpha, endAlpha, fadePercentage);
            yield return null;
        }

        fadeImageCanvas.alpha = endAlpha;
        if (endAlpha <= 0)
        {
            fadeImage.enabled = false;
        }
    }
}
