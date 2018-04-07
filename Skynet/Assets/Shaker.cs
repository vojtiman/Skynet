using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour {

    public float xMin;
    public float xMax;

    public float yMin;
    public float yMax;

    public float zMin;
    public float zMax;

    public int forceMultiplier;
    public int probability;//"probability"

    // Use this for initialization
    void Start () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody) {
            if(Random.Range(0, 100) < probability)
            {
                float x = Random.Range(xMin, xMax);
                float y = Random.Range(yMin, yMax);
                float z = Random.Range(zMin, zMax);

                Vector3 r = new Vector3(x, y, z);
                other.attachedRigidbody.AddForce(r * forceMultiplier);
            }         
        }
            
    }
}
