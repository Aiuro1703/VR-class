using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMD_Manager : MonoBehaviour
{
    [SerializeField] GameObject XRplayer;
    [SerializeField] GameObject FPSplayer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Using Device:" + XRSettings.loadedDeviceName);
        if (XRSettings.isDeviceActive || XRSettings.loadedDeviceName == "OpenXR Display")
        {
            FPSplayer.SetActive(false);
            XRplayer.SetActive(true);

        }
        else
        {
            XRplayer.SetActive(false);
            FPSplayer.SetActive(true);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}