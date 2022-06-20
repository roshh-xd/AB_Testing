using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppsFlyerSDK;
public class AppsFlyerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void LogEvent()
    {
        AppsFlyer.sendEvent("Test", new Dictionary<string, string>() { { "A/b Testing", "Successful" } });
    }
}
