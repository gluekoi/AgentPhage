using UnityEngine;
using UnityEngine.UI;
using System.Collections; 

public class CancerDeathSceneFade : MonoBehaviour
{
  
private Image _deathFadeImage; 

private void Awake()
{
    _deathFadeImage = GetComponent<Image>();
}

public IEnumerator FadeInCoroutine(float duration)
{
    Color startColor = new Color(_deathFadeImage.color.r, _deathFadeImage.color.g, _deathFadeImage.color.b, 0); 
    Color targetColor = new Color(_deathFadeImage.color.r, _deathFadeImage.color.g, _deathFadeImage.color.b, 1); 

    yield return FadeCoroutine(startColor, targetColor, duration); 


}



private IEnumerator FadeCoroutine(Color startColor, Color targetColor, float duration)
{

    float elapsedTime = 0; 
    float elapsedPercentage = 0; 

    while (elapsedPercentage < 1)
    {
        elapsedPercentage = elapsedTime / duration;
        _deathFadeImage.color = Color.Lerp(startColor, targetColor, elapsedPercentage);
    
        yield return null; 
        elapsedTime += Time.deltaTime; 
    }

}

}
