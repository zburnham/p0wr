using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInputDetection : MonoBehaviour {

    private SteamVR_TrackedController _controller;
    private SteamVR_Controller.Device device;

    private void OnEnable()
    {
        _controller = GetComponent<SteamVR_TrackedController>();
        var index = _controller.controllerIndex;
        //Debug.Log("index is " + _controller.index);
        device = SteamVR_Controller.Input((int)index);
    }

    private void OnDisable()
    {
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
