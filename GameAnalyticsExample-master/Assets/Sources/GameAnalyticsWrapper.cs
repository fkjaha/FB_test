using GameAnalyticsSDK;
using UnityEngine;

public class GameAnalyticsWrapper : MonoBehaviour, IGameAnalyticsATTListener
 {
     private void Start()
     {
 #if UNITY_IOS && !UNITY_EDITOR
         GameAnalytics.RequestTrackingAuthorization(this);
 #endif
         GameAnalytics.Initialize();
     }
 
     public void GameAnalyticsATTListenerNotDetermined() {}
 
     public void GameAnalyticsATTListenerRestricted() {}
 
     public void GameAnalyticsATTListenerDenied() {}
 
     public void GameAnalyticsATTListenerAuthorized()
     {
         GameAnalytics.Initialize();
     }
 }
