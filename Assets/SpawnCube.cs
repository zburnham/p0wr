using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour {

    public GameObject cube;
    private SteamVR_TrackedController device;
    private bool IsFiring;

    public InputDetection spawner;

    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device controllerDevice
    {
        get
        {
            if (trackedObject == null)
                trackedObject = GetComponent<SteamVR_TrackedObject>();
            return (trackedObject == null) ? null : SteamVR_Controller.Input(0);
        }
    }

    // Use this for initialization
    void Start()
    {
        device = GetComponent<SteamVR_TrackedController>();
        //device.TriggerClicked += spawner.HandleTriggerClicked;
        //device.TriggerUnclicked += spawner.HandleTriggerUnclicked;
    }

    /*void Update ()
    {
        
        if (controllerDevice == null)
        {
            Debug.Log("Controller is null");
        }
        if (controllerDevice.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Spawning");
            Spawn();
        }
    }*/

    void Spawn(object sender, ClickedEventArgs e)
    {
        Debug.Log("Spawning");
        Instantiate(cube, transform.position, transform.rotation);
    }
}
