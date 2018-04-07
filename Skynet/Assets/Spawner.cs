using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject headTemplate;
    public GameObject Heads;

	// Use this for initialization
	void Start () {
        GameObject newHead = Instantiate(headTemplate, transform.position, Quaternion.identity) as GameObject;
        newHead.name = "Head";
        newHead.transform.parent = Heads.transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
