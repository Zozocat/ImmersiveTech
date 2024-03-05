using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInputManager : MonoBehaviour
{
    [SerializeField] GameObject VRRig;
    [SerializeField] GameObject FPSRig;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Using device: " + XRSettings.loadedDeviceName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
