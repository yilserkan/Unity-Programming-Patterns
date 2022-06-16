using UnityEngine;

namespace ProgrammingPatterns.Patterns.Observer_Pattern.Scripts.Events
{
    public class AchievementSystem : MonoBehaviour
    {
        private void Start()
        {
            PlayerPrefs.DeleteAll();

            PointOfInterest.OnPointOfInterestEntered += HandleOnPointOfInterestEntered;
        }

        private void OnDestroy()
        {
            PointOfInterest.OnPointOfInterestEntered -= HandleOnPointOfInterestEntered;
        }

        private void HandleOnPointOfInterestEntered(string poiName)
        {
            string achievementKey = "achievement" + poiName;
        
            if(PlayerPrefs.GetInt(achievementKey) == 1)
                return;
        
            Debug.Log("Unlocked" + poiName);
            PlayerPrefs.SetInt(achievementKey, 1);
        }
    }
}
