using UnityEngine;
using System.Collections; 


public class CancerDeathSceneController : MonoBehaviour
{
    
    [SerializeField]
    private float _deathFadeImageDuration; 

    private CancerDeathSceneFade _deathFadeImage; 
    
    private void Awake()
    {
        _deathFadeImage = GetComponentInChildren<CancerDeathSceneFade>(); 

    }

   private IEnumerator Start()
   {
    yield return new WaitForSeconds(3);
    yield return _deathFadeImage.FadeInCoroutine(_deathFadeImageDuration);

   }
}
