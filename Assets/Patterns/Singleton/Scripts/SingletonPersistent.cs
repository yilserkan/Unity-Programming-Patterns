using UnityEngine;

namespace ProgrammingPatterns.Patterns.Singleton.Scripts
{
   public class SingletonPersistent<T> : MonoBehaviour where T : MonoBehaviour
   {
      private static T _instance;
   
      public static T Instance
      {
         get { return _instance; }
      }

      private void Awake()
      {
         if (_instance == null)
         {
            _instance = this as T;
            DontDestroyOnLoad(this);
         }
         else
         {
            Destroy(this);
         }
      }
   }
}
