using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticTest : MonoBehaviour {

    private SteamVR_Controller.Device _device;
    private SteamVR_TrackedController _controller;
    private SteamVR_TrackedObject _trackedObject;

    private bool _enabled = false;

    private void OnEnable()
    {
        _controller = GetComponent<SteamVR_TrackedController>();
        
       
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update, triggering haptic");
        _trackedObject = GetComponent<SteamVR_TrackedObject>();
        _device = SteamVR_Controller.Input((int)_trackedObject.index);
        _device.TriggerHapticPulse(2000);
	}
}
