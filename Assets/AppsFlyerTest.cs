using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppsFlyerSDK;
using UnityEngine.UI;

public class AppsFlyerTest : MonoBehaviour
{
    [SerializeField] Button testButton;

    void Awake()
    {
        testButton.onClick.AddListener(LogEvent);
    }

    public void LogEvent()
    {
        Debug.Log("Start");
        AppsFlyer.sendEvent("Test", new Dictionary<string, string>() { { "A/b Testing", "Successful" } });
    }
}
