using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHeads : MonoBehaviour {

    public FakeHeadMovement fhm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Head")
        {
            fhm.HeadCollected();
            Destroy(other.gameObject);
        }
    }
}
