using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject ObjectToSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Spawn()
    {
        Debug.Log("Spawn called");
        GameObject newObject = Instantiate(ObjectToSpawn);
        newObject.transform.SetParent(null);
    }
}
