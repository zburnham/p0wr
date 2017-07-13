using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject ObjectToSpawn;
    public int TrailingObjectsLimit = 50;

    public List<GameObject> TrailingObjects = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Spawn()
    {
        //Debug.Log("Spawn called");
        GameObject newObject = Instantiate(ObjectToSpawn);
        newObject.transform.parent = null;
        newObject.transform.position = transform.position;
        TrailingObjects.Add(newObject);
        LimitObjects();
    }

    public void LimitObjects()
    {
        if (TrailingObjects.Count >= TrailingObjectsLimit)
        {
            Destroy(TrailingObjects[0]);
            TrailingObjects.RemoveAt(0);
        }
    }

    public void Zip()
    {
        TrailingObjects.ForEach(Remove);
    }

    private void Remove(GameObject myObject)
    {
        Destroy(myObject);
        TrailingObjects.Remove(myObject);
    }
}
