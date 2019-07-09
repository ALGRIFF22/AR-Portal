using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceDetection : MonoBehaviour
{
    [SerializeField]
    private GameObject ARCoreDevice;
    [SerializeField]
    private GameObject ARKitDevice;

#if UNITY_EDITOR
#else
    private void Awake()
    { 
        if (Application.platform != RuntimePlatform.IPhonePlayer)
        {
            ARCoreDevice.SetActive(true);
            ARKitDevice.SetActive(false);
        }
        else
        {
            ARCoreDevice.SetActive(false);
            ARKitDevice.SetActive(true);
        }
    }
#endif
}
