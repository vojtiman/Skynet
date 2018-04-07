using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody) {
            if(Random.Range(0, 100) > 90)
            {
                float x = Random.Range(-10, 10);
                float y = Random.Range(-200, 10);
                float z = Random.Range(-10, 10);
                Vector3 r = new Vector3(x, y, z);
                other.attachedRigidbody.AddForce(r * 100);
            }         
        }
            
    }
}
