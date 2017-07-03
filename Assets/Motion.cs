using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour {

    public float angularVelocity = 10000.0f;
    protected float _rotationX;
    protected float _rotationY;
    protected float _rotationZ;
    private Vector3 axisOfRotation;

    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;

    // Use this for initialization
    void Start ()
    {
        axisOfRotation = Random.onUnitSphere;
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(axisOfRotation, angularVelocity * Time.smoothDeltaTime);
        //device = SteamVR_Controller.Input((int)trackedObject.index);
        //device.TriggerHapticPulse();
	}
}
