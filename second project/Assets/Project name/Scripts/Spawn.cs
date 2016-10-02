using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject prefab;

    public float interval = 1.0f;

	void Start () {
        InvokeRepeating("Spawns", interval, interval);
        
	}
	void Spawns () {
        GameObject.Instantiate(prefab, transform.position, transform.rotation);
       
    }
}

