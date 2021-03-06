﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InputDetection : MonoBehaviour
{
    public SpawnerEngine SpawnerEngine;

    public GameObject spawnedObject;
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;
    public int spawnDelay = 200;
    private int _elapsedTime = 0;

    public int snapBackSpeed = 5;
    private int _currentSnapBackDelay = 0;
    public int numberOfObjectsTrailing = 200;
    private bool _zipping = false;

    public List<GameObject> trailingObjects = new List<GameObject>();
    public int trailingObjectsCount = 50;

    private bool _isClicked = false;

    private SteamVR_TrackedController _controller;
    private SteamVR_TrackedObject _trackedObject;
    private SteamVR_Controller.Device _device;

    

    private void OnEnable()
    {
        _controller = GetComponent<SteamVR_TrackedController>();
        _trackedObject = GetComponent<SteamVR_TrackedObject>();

        //_controller.TriggerClicked += HandleTriggerClicked;
        //_controller.TriggerUnclicked += HandleTriggerUnclicked;
        _controller.Gripped += HandleGripped;
        _controller.Ungripped += HandleUngripped;
        //_device = SteamVR_Controller.Input((int)_controller.controllerIndex);
        SpawnerEngine = GetComponent<SpawnerEngine>();

    }

    private void OnDisable()
    {
        //_controller.TriggerClicked -= HandleTriggerClicked;
        //_controller.PadClicked -= HandlePadClicked;
    }

    #region Spawning

    public void HandleGripped(object sender, ClickedEventArgs e)
    {
        _isClicked = true;
        SpawnerEngine.SpawnObject();
    }

    public void HandleUngripped(object sender, ClickedEventArgs e)
    {
        _isClicked = false;
        _elapsedTime = 0;

        SpawnerEngine.Zip();
    }
    
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isClicked)
        {
            _trackedObject = GetComponent<SteamVR_TrackedObject>();
           _device = SteamVR_Controller.Input((int)_controller.controllerIndex);
            
            _elapsedTime++;

            if (_elapsedTime >= spawnDelay)
            {
                
                _device.TriggerHapticPulse(250);
                SpawnerEngine.SpawnObject();
                /*if (trailingObjects.Count >= numberOfObjectsTrailing)
                {
                    GameObject toDestroy = trailingObjects[0];
                    Destroy(toDestroy);
                    trailingObjects.RemoveAt(0);
                }*/
                _elapsedTime = 0;
            }

            _currentSnapBackDelay++;
           /* if (_currentSnapBackDelay >= snapBackSpeed + 1 && _zipping == true)
            {
                GameObject toZipUp = trailingObjects[0];
                Destroy(toZipUp);
                trailingObjects.RemoveAt(0);
                if (trailingObjects.Count == 0)
                {
                    _zipping = false;
                } 
            }*/
            
        }
    }
    #endregion
}
