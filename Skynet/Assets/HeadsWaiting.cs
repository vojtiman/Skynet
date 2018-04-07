using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadsWaiting : MonoBehaviour {

    public GameObject HeadsWaitingGO;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Head")
        {
            other.gameObject.transform.parent = HeadsWaitingGO.transform;
        }
    }
}
