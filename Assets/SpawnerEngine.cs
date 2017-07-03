using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEngine : MonoBehaviour {

    public static SpawnerEngine Instance;

    //public GameObject spawnObject;
    public Spawner spawner;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public void SpawnObject()
    {
        spawner.Spawn();
        //logic here for any trailers
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
